using CloudApi.Providers;
using CloudApi.ToolHelper;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudApi.Dueros
{
    public class IndexJob : IJob//必须实现这个接口
    {
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                //加载进REDIS缓存中
                FunctionHelper.writeLog("", "in", "IndexJob");
                RedisCacheSaveThread.CacheAll();
            }
            catch (Exception ex)
            {
                FunctionHelper.writeLog("RedisCacheSaveThread.cs => threadStart error:", ex.Message, "ThreadError");
            }
        }
    }
}