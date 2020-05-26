namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_timer_day")]
    public partial class t_device_timer_day
    {
        public int id { get; set; }

        public int? timeId { get; set; }

        public int? dayOfWeek { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
