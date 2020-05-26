namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.android_scene")]
    public partial class android_scene
    {
        public int id { get; set; }

        public int configId { get; set; }

        public int? customerId { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(200)]
        public string imgsCover { get; set; }

        [StringLength(600)]
        public string description { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
