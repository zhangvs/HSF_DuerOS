using CloudApi.Dueros.Models.ReturnModel;
using CloudApi.ToolHelper;
using Hsf.Redis.Service;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace CloudApi.Dueros
{
    public class ThreadCheckModel
    {
        private static string DuerOSSyncUrl = System.Configuration.ConfigurationManager.AppSettings["DuerOSSyncUrl"] + "";
        private static string DuerOSSyncBotId = System.Configuration.ConfigurationManager.AppSettings["DuerOSSyncBotId"] + "";
        private static string DuerOSChangeReportUrl = System.Configuration.ConfigurationManager.AppSettings["DuerOSChangeReportUrl"] + "";
        public void StartThread()
        {
            Thread thread = new Thread(new ThreadStart(ThreadGetMqttMsg.GetMqttData));
            thread.Start();
        }


        /// <summary>
        /// 
        /// </summary>
        public static class ThreadGetMqttMsg
        {
            //https://xiaodu.baidu.com/saiya/smarthome/changereport
            /// <summary>
            /// 
            /// </summary>
            public static void GetMqttData()
            {
                while (true)
                {
                    //这儿模拟一次发送请求给小度，通知小度来请求设备状态
                    var devId = "02ea45da-bf64-4ab2-a913-6ff5335f7c7d";//假设你自己从某个渠道获取到了变化状态的设备ID
                    //var uids = new string[0];//对应授权过的小度的用户OpenUid
                    string[] uids = { "ee65663a03e810214acc0ac1c18260e7" };

                    for (int i = 0; i < uids.Length; i++)
                    {
                        var tempPostModel = new ChangeReportRequestModel()
                        {
                            header = new Models.CommonModel.Head()
                            {
                                messageId = FunctionHelper.GetTimStamp() + "" + i,
                                name = "ChangeReportRequest",
                                @namespace = "DuerOS.ConnectedHome.Control",
                                payloadVersion = 1
                            },
                            payload = new Models.ReturnModel.Payload.ChangeReportRequestPayload()
                            {
                                botId = DuerOSSyncBotId,
                                openUid = uids[i],
                                appliance = new Models.ReturnModel.Payload.TempAppliance()
                                {
                                    applianceId = devId,
                                    attributeName = "turnOnState"
                                }
                            }
                        };

                        var tempRes = ToolHelper.FunctionHelper.PostJsonString(DuerOSChangeReportUrl, JsonConvert.SerializeObject(tempPostModel));
                        ToolHelper.FunctionHelper.writeLog("", tempRes, "01008postResult");
                    }
                    Thread.Sleep(15000);
                }
            }

        }



        /// <summary>
        /// 收到YunZig状态改变队列数据
        /// </summary>
        public static void GetYunZigStateChangeQueue()
        {
            Task.Run(() =>
            {
                ToolHelper.FunctionHelper.writeLog("手动或App上报状态", "启动线程……", "YunZigStateChangeQueue");
                try
                {
                    using (RedisListService service = new RedisListService())
                    {
                        service.Subscribe("YunZigStateChangeQueue", (c, cachekey, iRedisSubscription) =>
                        {
                            //log.Debug($"收到YunZig状态改变队列数据，同步状态 {c}:{message}，Dosomething else");
                            //ToolHelper.FunctionHelper.writeLog("状态订阅", cachekey, "YunZigStateChangeQueue");
                            using (RedisHashService serviceHash = new RedisHashService())
                            {
                                //获取openUid
                                string openUid = serviceHash.GetValueFromHash("DuerOSOpenUid_Device", cachekey);
                                if (!string.IsNullOrEmpty(openUid))
                                {
                                    var tempPostModel = new ChangeReportRequestModel()
                                    {
                                        header = new Models.CommonModel.Head()
                                        {
                                            messageId = FunctionHelper.GetTimStamp() + "",
                                            name = "ChangeReportRequest",
                                            @namespace = "DuerOS.ConnectedHome.Control",
                                            payloadVersion = 1
                                        },
                                        payload = new Models.ReturnModel.Payload.ChangeReportRequestPayload()
                                        {
                                            botId = DuerOSSyncBotId,
                                            openUid = openUid,
                                            appliance = new Models.ReturnModel.Payload.TempAppliance()
                                            {
                                                applianceId = cachekey,
                                                attributeName = "turnOnState"
                                            }
                                        }
                                    };

                                    var tempRes = ToolHelper.FunctionHelper.PostJsonString(DuerOSChangeReportUrl, JsonConvert.SerializeObject(tempPostModel));//{"status":21093,"msg":"Appliance specificed not exist, stop sync","messageId":"1557135094549","data":{"updated_attribute_num":0}}
                                    ToolHelper.FunctionHelper.writeLog("手动或App上报状态： "+ cachekey, tempRes, "YunZigStateChangeQueue");
                                    Thread.Sleep(100);
                                }
                            }
                        });//blocking
                    }
                }
                catch (Exception ex)
                {
                    FunctionHelper.writeLog("状态订阅异常", ex.Message, "YunZigStateChangeQueue");
                    throw;
                }

            });
        }


        /// <summary>
        /// 收到Lot设备同步订阅
        /// </summary>
        public static void GetLotDeviceChangeQueue()
        {
            Task.Run(() =>
            {
                ToolHelper.FunctionHelper.writeLog("主动上报设备改变", "启动线程……", "LotDeviceChangeQueue");
                try
                {
                    using (RedisListService service = new RedisListService())
                    {
                        service.Subscribe("LotDeviceChangeQueue", (c, Account, iRedisSubscription) =>
                        {
                            //ToolHelper.FunctionHelper.writeLog("设备同步订阅", Account, "LotDeviceChangeQueue");
                            using (RedisHashService serviceHash = new RedisHashService())
                            {
                                //获取openUid
                                string openUid = serviceHash.GetValueFromHash("DuerOSOpenUid_Host", Account);
                                if (!string.IsNullOrEmpty(openUid))
                                {
                                    var tempPostModel = new DuerOSSyncDevice()
                                    {
                                        botId = DuerOSSyncBotId,
                                        logId = FunctionHelper.GetTimStamp() + Account,
                                        openUids = new List<string> { openUid }
                                    };

                                    var tempRes = ToolHelper.FunctionHelper.PostJsonString(DuerOSSyncUrl, JsonConvert.SerializeObject(tempPostModel));//{"status":21093,"msg":"Appliance specificed not exist, stop sync","messageId":"1557135094549","data":{"updated_attribute_num":0}}
                                    //{"status":0,"msg":"ok","logid":"1557387335989AAA","data":{"discover":"succeed","failed":[],"succeed":["ee65663a03e810214acc0ac1c18260e7"]}}
                                    ToolHelper.FunctionHelper.writeLog("主动上报设备改变： "+ Account, tempRes, "LotDeviceChangeQueue");
                                    Thread.Sleep(100);
                                }
                            }
                        });
                    }
                }
                catch (Exception ex)
                {
                    FunctionHelper.writeLog("设备同步订阅异常", ex.Message, "LotDeviceChangeQueue");
                    throw;
                }

            });
        }
    }



}