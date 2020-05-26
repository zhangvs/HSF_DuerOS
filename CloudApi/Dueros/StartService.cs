using CloudApi.ToolHelper;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudApi.Dueros
{
    public class StartService
    {
        /// <summary>
        /// 开启定时服务
        /// </summary>
        public static void Start()
        {
            FunctionHelper.writeLog(DateTime.Now.ToString() + "StartService=》Start：开始配置服务", "in", "IndexJob");
            ISchedulerFactory sf = new StdSchedulerFactory();
            IScheduler scheduler = sf.GetScheduler(); //创建调度实例
                                                      //创建任务实例
            IJobDetail job = JobBuilder.Create<IndexJob>().WithIdentity(new JobKey("job1")).Build();
            //创建触发器实例
            ITrigger trigger = TriggerBuilder.Create().StartAt(DateTime.Now.AddSeconds(0)).WithCronSchedule("0 */10 * * * ?").Build();
            FunctionHelper.writeLog(DateTime.Now.ToString() + "StartService=》Start：开始绑定定时任务", "in", "IndexJob");
            // 如果需要多个的话，只需要绑定多个即可
            scheduler.ScheduleJob(job, trigger); //绑定触发器和任务

            scheduler.Start(); //启动监控
            FunctionHelper.writeLog(DateTime.Now.ToString() + "StartService=》Start：开始监控定时任务", "in", "IndexJob");

        }
    }
}