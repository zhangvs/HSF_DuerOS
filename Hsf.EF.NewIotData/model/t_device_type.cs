namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_type")]
    public partial class t_device_type
    {
        public int id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(50)]
        public string typeNo { get; set; }

        [StringLength(200)]
        public string icon { get; set; }

        [StringLength(1000)]
        public string stopWatch { get; set; }

        [StringLength(200)]
        public string source { get; set; }

        [StringLength(500)]
        public string remark { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }

        public int? createUser { get; set; }

        public int? lastUpdateUser { get; set; }

        public int? status { get; set; }
    }
}
