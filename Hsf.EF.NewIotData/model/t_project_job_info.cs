namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_project_job_info")]
    public partial class t_project_job_info
    {
        public int id { get; set; }

        public int? customerId { get; set; }

        public int? reportCustUserId { get; set; }

        public int type { get; set; }

        public int? linkDeviceId { get; set; }

        public int? linkProjectId { get; set; }

        [Required]
        [StringLength(20)]
        public string name { get; set; }

        [StringLength(200)]
        public string description { get; set; }

        public int isRule { get; set; }

        public int? ruleId { get; set; }

        public int warnLevel { get; set; }

        public int sourceType { get; set; }

        public int? planId { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? finalTime { get; set; }

        [StringLength(500)]
        public string imgList { get; set; }

        [StringLength(50)]
        public string enableUsers { get; set; }

        [StringLength(50)]
        public string viewUsers { get; set; }

        [StringLength(50)]
        public string workUsers { get; set; }

        public int warnStatus { get; set; }

        public int flowStatus { get; set; }

        public int? status { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? createTime { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updateTime { get; set; }

        public int? createUser { get; set; }

        public int? updateUser { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? redTime { get; set; }
    }
}
