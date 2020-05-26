namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_ability_set")]
    public partial class t_device_ability_set
    {
        public int id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        public int? status { get; set; }

        [StringLength(500)]
        public string remark { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
