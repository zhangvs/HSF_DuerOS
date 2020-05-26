namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_project_job_log")]
    public partial class t_project_job_log
    {
        public int id { get; set; }

        public int jobId { get; set; }

        [StringLength(200)]
        public string description { get; set; }

        [StringLength(500)]
        public string imgList { get; set; }

        public int? operateType { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? createTime { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updateTime { get; set; }

        public int? createUser { get; set; }

        public int? updateUser { get; set; }
    }
}
