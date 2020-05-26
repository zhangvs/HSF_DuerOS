namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_timer")]
    public partial class t_device_timer
    {
        public int id { get; set; }

        public int? deviceId { get; set; }

        public int? userId { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? timerType { get; set; }

        public long? executeTime { get; set; }

        public int? status { get; set; }

        public int? executeRet { get; set; }

        public int? type { get; set; }

        public int? hour { get; set; }

        public int? minute { get; set; }

        public int? second { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
