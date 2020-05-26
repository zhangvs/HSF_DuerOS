namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.wx_bg_img")]
    public partial class wx_bg_img
    {
        public int id { get; set; }

        public int? configId { get; set; }

        public int? customerId { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(200)]
        public string bgImg { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
