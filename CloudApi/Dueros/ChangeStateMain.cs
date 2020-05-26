using CloudApi.Dueros.Models.ReturnModel;
using CloudApi.ToolHelper;
using Hsf.Framework.Log;
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
    public class ChangeStateMain
    {
        //private static Logger log = Logger.CreateLogger(typeof(ChangeStateMain));
        private static string DuerOSSyncUrl = System.Configuration.ConfigurationManager.AppSettings["DuerOSSyncUrl"] + "";
        private static string DuerOSSyncBotId = System.Configuration.ConfigurationManager.AppSettings["DuerOSSyncBotId"] + "";
        private static string DuerOSChangeReportUrl = System.Configuration.ConfigurationManager.AppSettings["DuerOSChangeReportUrl"] + "";
        /// <summary>
        /// 放入百度音响控制队列
        /// </summary>
        /// <param name="state"></param>
        /// <param name="cachekey"></param>
        /// <returns></returns>
        public static bool PutMqttData(string cachekey, bool state)
        {
            using (RedisListService service = new RedisListService())
            {
                service.RPush("DuerOSControlQueue", cachekey + "$" + state);
                //log.Debug($"放入百度音响控制队列：{cachekey}${state}");
                FunctionHelper.writeLog("放入状态改变队列", $"{cachekey}${state}", "ChangeStateMain");
                //需不需要确认器？？可以不要
                //if (StateResult(cachekey, state.ToString()))
                //{
                //    return true;
                //}
                //else
                //{
                //    //log.Debug($"设备状态改变超时失败！ cachekey：{cachekey}！");
                //    FunctionHelper.writeLog("超时失败", $"{cachekey}${state}", "ChangeStateMain");
                //    return false;
                //}
                return true;
            }
        }

        #region 确认器
        /// <summary>
        /// 确认器，读取缓存状态，半秒读取一次，共读取3秒左右，没反应就返回失败
        /// </summary>
        /// <param name="cachekey"></param>
        /// <param name="st"></param>
        /// <returns></returns>
        public static bool StateResult(string cachekey, string st)
        {
            using (RedisHashService service = new RedisHashService())
            {
                bool state = false;
                int i = 0;
                while (i < 20)//6s，次数限制redis
                {
                    i++;
                    Thread.Sleep(200);
                    //读取缓存状态
                    string status = service.GetValueFromHash("DeviceStatus", cachekey);
                    if (status == st)
                    {
                        //log.Debug($"设备状态改变成功！ cachekey：{cachekey}！轮询次数： {i}");
                        FunctionHelper.writeLog("改变成功", $"{cachekey}${state} 轮询次数： {i}", "ChangeStateMain");
                        state = true;
                        break;
                    }
                }
                return state;
            }
        }
        #endregion

    }
}