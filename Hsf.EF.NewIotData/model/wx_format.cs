namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.wx_format")]
    public partial class wx_format
    {
        public int id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(200)]
        public string htmlUrl { get; set; }

        [StringLength(500)]
        public string icon { get; set; }

        [StringLength(255)]
        public string previewImg { get; set; }

        public int? status { get; set; }

        public int? type { get; set; }

        [StringLength(2000)]
        public string typeIds { get; set; }

        public int? owerType { get; set; }

        [StringLength(2000)]
        public string customerIds { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        [StringLength(200)]
        public string version { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }

        public int? createUserId { get; set; }

        public int? updateUserId { get; set; }
    }
}
