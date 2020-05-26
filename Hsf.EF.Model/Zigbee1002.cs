using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsf.EF.Model
{
    public class Zigbee1002
    {
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int serial { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object control { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string zigbee { get; set; }
    }

    public class Control
    {
        /// <summary>
        /// 
        /// </summary>
        public bool on { get; set; }
        /// <summary>
        /// 表示百分比
        /// </summary>
        public int pt { get; set; }
        /// <summary>
        /// 烟感状态
        /// </summary>
        public int sta { get; set; }

        //on on  on on
        //bri bri bri bri
        //hue hue hue hue
        //sat sat sat sat
        //ctp uint16_t    色温状态：取值范围: 153 - 499	否
        //sta uint8_t 烟感状态    否
        //zid uint8_t 烟感区域    否
        //nlux    字符串 当前光照度   否
        //llux    uint8_t 光照度等级状态 否
        //tlux    字符串 目标光照度   否
        //pt  uint8_t 表示百分比   否
        //ctrl    uint8_t	0：关，向下，反转等；1：开，向上，正转等；2：停止 否

    }
}
