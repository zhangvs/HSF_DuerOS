using CloudApi.Dueros;
using CloudApi.Dueros.Models.CommonModel;
using CloudApi.Dueros.Models.ReceiveModel;
using CloudApi.Dueros.Models.ReturnModel;
using CloudApi.Dueros.Models.ReturnModel.Payload;
using CloudApi.Models;
using CloudApi.Providers;
using CloudApi.ToolHelper;
using Hsf.EF.Model;
using Hsf.Framework.Log;
using Hsf.Redis.Service;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace CloudApi.Controllers
{
    public class DuerOSController : ApiController
    {
        //private Logger log = Logger.CreateLogger(typeof(DuerOSController));
        /// <summary>
        /// 
        /// </summary>
        /// <param name="receiveObj"></param>
        /// <returns></returns>
        public HttpResponseMessage ReceiveMsg([FromBody]JObject receiveObj)
        {
            //log.Debug($"收到信息：{receiveObj}");
            ToolHelper.FunctionHelper.writeLog("receiveObj", JsonConvert.SerializeObject(receiveObj), "DuerOSReceiveObj");
            object res = null;


            var commonModel = JsonConvert.DeserializeObject<CommonReceiveModel>(receiveObj.ToString());

            var tokenModel = CacheData.GetAccessTokenCache(commonModel.payload.accessToken);
            if (tokenModel == null || string.IsNullOrEmpty(tokenModel.HostId))
            {//从缓存里找不到了，说明授权过期了.
                //log.Debug($"从缓存里找不到了，说明授权过期了.：{commonModel.payload.accessToken}");
                FunctionHelper.writeLog("accessToken过期", commonModel.payload.accessToken, "DeviceDiscoverHandleError");
                //new CommonReceiveModel()
                //{
                //    header = new Dueros.Models.CommonModel.Head()
                //    {
                //        messageId = commonModel.header.messageId,
                //        name = "ExpiredAccessTokenError",
                //        @namespace = commonModel.header.@namespace,
                //        payloadVersion = commonModel.header.payloadVersion
                //    }
                //};
                return FunctionHelper.SerializerJson(res);
            }

            string receiveNamespace = commonModel.header.@namespace;

            if (receiveNamespace.Equals("DuerOS.ConnectedHome.Discovery"))
            {//发现设备,向网关查设备列表
                res = Discove(commonModel, tokenModel);
            }
            else if (receiveNamespace.Equals("DuerOS.ConnectedHome.Control"))
            {//控制设备
                #region 控制设备
                string devType = commonModel.payload.appliance.additionalApplianceDetails.devType + "";//设备的实际类型

                string devId = commonModel.payload.appliance.applianceId + "";

                string operName = commonModel.header.name.Replace("Request", "");

                var controlModel = JsonConvert.DeserializeObject<ControlModel>(receiveObj.ToString());

                object resPayload = new object();//这儿写你自己的处理逻辑，与返回的结果

                var tempRes = new ControlReturnModel
                {
                    header = new Head()
                    {
                        messageId = commonModel.header.messageId,
                        name = "",//操作失败时当作设备不在线处理
                        @namespace = commonModel.header.@namespace,
                        payloadVersion = commonModel.header.payloadVersion
                    },
                    payload = resPayload
                };


                List<AttributesItem> attributes = new List<AttributesItem>();
                bool stateChange = false;
                switch (operName)
                {
                    case "TurnOn"://打开
                        stateChange = ChangeStateMain.PutMqttData(devId, true);
                        if (stateChange)
                        {
                            attributes.Add(GetAttributesItem("ON"));
                            tempRes.payload = new CommonPayload()
                            {
                                attributes = attributes
                            };
                        }
                        break;
                    case "TurnOff"://关闭
                        stateChange = ChangeStateMain.PutMqttData(devId, false);
                        if (stateChange)
                        {
                            attributes.Add(GetAttributesItem("OFF"));
                            tempRes.payload = new CommonPayload()
                            {
                                attributes = attributes
                            };
                        }
                        break;
                    default:
                        break;
                }

                if (stateChange)
                {
                    tempRes.header.name = commonModel.header.name.Replace("Request", "Confirmation");
                }
                else
                {
                    FunctionHelper.writeLog(receiveObj.ToString(), "状态没获取到...", "DuerOSCantGetDeviceState");
                }
                //string errmsg = "";
                ////错误信息自行定义...
                //if (errmsg == "0")
                //{//成功 
                //    tempRes.header.name = commonModel.header.name.Replace("Request", "Confirmation");
                //}
                //else if (errmsg == "1")
                //{//操作失败
                //    tempRes.header.name = "TargetOfflineError";
                //}
                //else if (errmsg == "2")
                //{//数据解析出错 
                //    tempRes.header.name = "TargetConnectivityUnstableError";
                //}
                //else if (errmsg == "3")
                //{
                //    FunctionHelper.writeLog(receiveObj.ToString(), "状态没获取到...", "DuerOSCantGetDeviceState");
                //}
                //else if (errmsg == "999")
                //{ //操作超时
                //    tempRes.header.name = "TargetOfflineError";
                //}

                res = tempRes;

                #endregion
            }
            else if (receiveNamespace.Equals("DuerOS.ConnectedHome.Query"))
            {//查询设备

                //获取设备当前状态返回给小度
                switch (commonModel.header.name)
                {
                    case "ReportStateRequest"://更新设备状态
                        //发指令去查设备状态
                        using (RedisHashService service = new RedisHashService())
                        {
                            List<AttributesItem> attributeslist = new List<AttributesItem>();
                            string cachekey = commonModel.payload.appliance.applianceId;
                            AttributesItem attributes= GetStateByCachekey(service, cachekey);
                            attributeslist.Add(attributes);
                            var tempRes = new ReportStateResponseReturnModel()
                            {
                                header = commonModel.header,
                                payload = new CommonPayload()
                                {
                                    attributes = attributeslist
                                }
                            };
                            tempRes.header.name = tempRes.header.name.Replace("Request", "Response");
                            res = tempRes;
                        }
                        break;
                    default:
                        break;
                }
            }

            FunctionHelper.writeLog("返回的数据", JsonConvert.SerializeObject(res), "Test");
            return FunctionHelper.SerializerJson(res);
        }
        
        /// <summary>
        /// 设备发现方法
        /// </summary>
        /// <param name="commonModel"></param>
        /// <param name="tokenModel"></param>
        /// <returns></returns>
        private object Discove(CommonReceiveModel commonModel, IntelligentHostCacheModel tokenModel)
        {
            //IntelligentHostCacheModel cacheModel = CacheData.GetAccessTokenCache(receiveObj.payload.accessToken);
            //CacheData.SetOpenUid(cacheModel.AccessToken, cacheModel, commonModel.payload.openUid);
            try
            {
                using (RedisHashService service = new RedisHashService())
                {
                    string hostId = tokenModel.HostId;//账号
                    string openUid = commonModel.payload.openUid;
                    //设置设备与OpenUid的绑定关系
                    service.SetEntryInHash("DuerOSOpenUid_Host", hostId, openUid);
                    //拼装返回消息格式
                    DiscoveReturnModel resModel = new DiscoveReturnModel()
                    {
                        header = new Dueros.Models.CommonModel.Head()
                        {
                            messageId = commonModel.header.messageId,
                            name = commonModel.header.name.Replace("Request", "Response"),
                            @namespace = commonModel.header.@namespace,
                            payloadVersion = commonModel.header.payloadVersion
                        },
                        payload = new DiscoverPayload()
                        {
                            discoveredGroups = new List<DiscoveredGroup>(),
                            discoveredAppliances = new List<DiscoveredAppliance>()
                        }
                    };

                    //获取当前百度账号的设备列表，先找缓存
                    string discoverPayloadJson = service.GetValueFromHash("DuerOS_DiscoverPayload", hostId);

                    if (!string.IsNullOrEmpty(discoverPayloadJson))
                    {
                        resModel.payload = JsonConvert.DeserializeObject<DiscoverPayload>(discoverPayloadJson);
                    }
                    else
                    {
                        List<host_room> roomList = null;//房间区域列表
                        List<host_device> roomDeviceList = null;//区域设备列表

                        //1.找当前账号的房间列表区域
                        string roomListJson = service.GetValueFromHash("Room", hostId);
                        if (!string.IsNullOrEmpty(roomListJson))
                        {
                            roomList = JsonConvert.DeserializeObject<List<host_room>>(roomListJson);
                        }
                        else
                        {
                            using (HsfDBContext hsfDBContext = new HsfDBContext())
                            {
                                //默认房间为0，查询当前账号所有设备列表
                                roomList = hsfDBContext.host_room.Where(t => t.Account == hostId && t.DeleteMark == 0).OrderBy(t => t.CreateTime).ToList();

                                //缓存当前房间的设备列表,不包括状态,不管空与否都缓存，防止第二次还查数据库RoomDevices
                                service.SetEntryInHash("Room", hostId, JsonConvert.SerializeObject(roomList));
                            }
                        }
                        //2.组装区域列表
                        if (roomList.Count > 0)
                        {
                            //房间列表不为空，则拼装区域json
                            foreach (var item in roomList)
                            {
                                //获取当前区域的设备列表
                                roomDeviceList= GetDeviceListByRoom(service, hostId, item.posid);
                                if (roomDeviceList!=null)
                                {
                                    List<string> applianceIds = new List<string>();
                                    foreach (var dev in roomDeviceList)
                                    {
                                        applianceIds.Add(dev.cachekey);
                                    }

                                    DiscoveredGroup discoveredGroup = new DiscoveredGroup()
                                    {
                                        groupName = item.chinaname,
                                        applianceIds = applianceIds,
                                        groupNotes = item.chinaname + "分组控制",
                                        additionalGroupDetails = { }
                                    };
                                    resModel.payload.discoveredGroups.Add(discoveredGroup);
                                }
                            }
                        }
                        
                        //调用逻辑获取缓存中0房间所有的设备
                        List<host_device> allDeviceList = GetDeviceListByRoom(service, hostId, "0");
                        foreach (var item in allDeviceList)
                        {
                            //类型对照表
                            List<string> applianceTypes = null;
                            List<string> actions = null;
                            //根据对照，获取百度的设备类型type，操作action
                            GetDuerOSDveType(item.devtype, out applianceTypes, out actions);

                            //拼装发给百度的设备信息
                            if (applianceTypes != null && actions != null)
                            {
                                DiscoveredAppliance discoveredAppliance = new DiscoveredAppliance()
                                {
                                    applianceTypes = applianceTypes,
                                    applianceId = item.cachekey,//不使用id，使用mac+port
                                    modelName = item.devtype,
                                    version = "1.0",
                                    friendlyName = item.chinaname,
                                    friendlyDescription = "",
                                    isReachable = true,
                                    actions = actions,
                                    additionalApplianceDetails = { },
                                    manufacturerName = "DASKLIMA"
                                };
                                //以对象数组返回客户关联设备云帐户的设备、场景
                                resModel.payload.discoveredAppliances.Add(discoveredAppliance);
                                //设置设备与OpenUid的绑定关系
                                service.SetEntryInHash("DuerOSOpenUid_Device", item.cachekey, openUid);
                            }
                        }
                        //场景处理，后续

                        //缓存百度设备列表payload，不包含状态
                        service.SetEntryInHash("DuerOS_DiscoverPayload", hostId, JsonConvert.SerializeObject(resModel.payload));

                    }

                    //设备状态详情信息，都要执行，因为缓存的DuerOS_DiscoverPayload不存状态
                    foreach (var item in resModel.payload.discoveredAppliances)
                    {
                        List<AttributesItem> attributes = new List<AttributesItem>();
                        //获取当前缓存状态
                        AttributesItem attribute = GetStateByCachekey(service, item.applianceId);
                        attributes.Add(attribute);
                        item.attributes = attributes;
                    }

                    return resModel;
                }
            }
            catch (Exception ex)
            {
                FunctionHelper.writeLog("GetDevice error:", ex.Message + "   " + ex.StackTrace, "DeviceDiscoverHandleError");
                return null;
            }
        }

        /// <summary>
        /// 根据房间获取房间内设备列表
        /// </summary>
        /// <param name="service"></param>
        /// <param name="hostId"></param>
        /// <param name="posid"></param>
        /// <returns></returns>
        public List<host_device> GetDeviceListByRoom(RedisHashService service,string hostId, string posid)
        {
            List<host_device> roomDeviceList = null;
            //获取当前区域的设备列表
            string roomDeviceListJson = service.GetValueFromHash("RoomDevices", hostId + "|" + posid);
            if (!string.IsNullOrEmpty(roomDeviceListJson))
            {
                roomDeviceList = JsonConvert.DeserializeObject<List<host_device>>(roomDeviceListJson);
            }
            else
            {
                if (posid!="0")
                {
                    using (HsfDBContext hsfDBContext = new HsfDBContext())
                    {
                        //默认房间为0，查询当前账号所有设备列表
                        roomDeviceList = hsfDBContext.host_device.Where(t => t.account == hostId && t.devposition == posid && t.deletemark == 0).OrderBy(t => t.createtime).ToList();

                        //缓存当前房间的设备列表,不包括状态,不管空与否都缓存，防止第二次还查数据库RoomDevices
                        service.SetEntryInHash("RoomDevices", hostId + "|" + posid, JsonConvert.SerializeObject(roomDeviceList));
                    }
                }
                else
                {
                    using (HsfDBContext hsfDBContext = new HsfDBContext())
                    {
                        //默认房间为0，查询当前账号所有设备列表
                        roomDeviceList = hsfDBContext.host_device.Where(t => t.account == hostId && t.deletemark == 0).OrderBy(t => t.createtime).ToList();

                        //缓存当前房间的设备列表,不包括状态,不管空与否都缓存，防止第二次还查数据库RoomDevices
                        service.SetEntryInHash("RoomDevices", hostId + "|0", JsonConvert.SerializeObject(roomDeviceList));
                    }
                }

            }
            return roomDeviceList;
        }

        /// <summary>
        /// 获取缓存状态
        /// </summary>
        /// <param name="service"></param>
        /// <param name="cachekey"></param>
        /// <returns></returns>
        public AttributesItem GetStateByCachekey(RedisHashService service,string cachekey)
        {
            string devstate = "";
            if (!string.IsNullOrEmpty(cachekey))
            {
                //读取缓存状态
                string status = service.GetValueFromHash("DeviceStatus", cachekey);
                if (string.IsNullOrEmpty(status))
                {
                    //离线
                    devstate = "false";
                }
                else
                {
                    devstate = status.ToLower();
                }
            }

            return GetAttributesItem(devstate);
        }
        /// <summary>
        /// 拼装百度格式状态信息
        /// </summary>
        /// <param name="devstate"></param>
        /// <returns></returns>
        public AttributesItem GetAttributesItem(string devstate)
        {
            AttributesItem attribute = new AttributesItem()
            {
                name = "turnOnState",
                value = devstate.Replace("false", "OFF").Replace("true", "ON"),
                scale = "",
                timestampOfSample = FunctionHelper.GetTimStamp(),
                uncertaintyInMilliseconds = 10
            };
            return attribute;
        }


        /// <summary>
        /// 匹配百度设备类型
        /// </summary>
        /// <param name="devtype"></param>
        /// <param name="applianceTypes"></param>
        /// <param name="actions"></param>
        public void GetDuerOSDveType(string devtype,out List<string> applianceTypes, out List<string> actions)
        {
            applianceTypes = null;
            actions = null;
            switch (devtype)
            {
                case "Panel_Zigbee":
                    applianceTypes = new List<string> { "LIGHT" };
                    actions = new List<string> { "turnOn", "turnOff" };
                    break;
                case "Smart_ZigbeeCurtain":
                    applianceTypes = new List<string> { "CURTAIN" };
                    actions = new List<string> { "turnOn", "turnOff" };
                    break;
                default:
                    break;
            }
        }
    }
}
