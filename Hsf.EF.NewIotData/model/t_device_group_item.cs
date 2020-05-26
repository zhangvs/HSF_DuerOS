namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_group_item")]
    public partial class t_device_group_item
    {
        public int id { get; set; }

        public int? deviceId { get; set; }

        public int? groupId { get; set; }

        public int? status { get; set; }

        public long? createTIme { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
