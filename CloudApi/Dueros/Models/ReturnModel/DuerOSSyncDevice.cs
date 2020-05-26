using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudApi.Dueros.Models.ReturnModel
{
    /// <summary>
    /// 设备信息同步消息
    /// </summary>
    public class DuerOSSyncDevice
    {
        /// <summary>
        /// 
        /// </summary>
        public string botId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string logId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> openUids { get; set; }
    }
}