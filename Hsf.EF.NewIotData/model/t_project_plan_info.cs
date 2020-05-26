namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_project_plan_info")]
    public partial class t_project_plan_info
    {
        public int id { get; set; }

        public int? customerId { get; set; }

        [Required]
        [StringLength(20)]
        public string name { get; set; }

        [Required]
        [StringLength(200)]
        public string description { get; set; }

        public int isRule { get; set; }

        public int? ruleId { get; set; }

        public int linkType { get; set; }

        public int? linkDeviceId { get; set; }

        public int? linkProjectId { get; set; }

        public DateTime? warnDate { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? nextExecuteTime { get; set; }

        public int? month { get; set; }

        public int? day { get; set; }

        public int cycleType { get; set; }

        public int? cycleNums { get; set; }

        public int? overTimeDays { get; set; }

        [StringLength(50)]
        public string enableUsers { get; set; }

        public int? status { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? createTime { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updateTime { get; set; }

        public int? createUser { get; set; }

        public int? updateUser { get; set; }
    }
}
