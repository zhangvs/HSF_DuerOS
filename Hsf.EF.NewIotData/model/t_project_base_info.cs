namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_project_base_info")]
    public partial class t_project_base_info
    {
        public int id { get; set; }

        public int? customerId { get; set; }

        [Required]
        [StringLength(20)]
        public string projectNo { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(200)]
        public string description { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? buildTime { get; set; }

        [StringLength(100)]
        public string buildAddress { get; set; }

        [StringLength(100)]
        public string gps { get; set; }

        [StringLength(100)]
        public string groupIds { get; set; }

        [StringLength(2000)]
        public string imgList { get; set; }

        public int? status { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? createTime { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updateTime { get; set; }

        public int? createUser { get; set; }

        public int? updateUser { get; set; }
    }
}
