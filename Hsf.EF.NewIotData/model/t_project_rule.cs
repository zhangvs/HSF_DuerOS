namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_project_rule")]
    public partial class t_project_rule
    {
        public int id { get; set; }

        public int? customerId { get; set; }

        public int? useType { get; set; }

        [StringLength(200)]
        public string monitorValue { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public int? typeId { get; set; }

        public int? warnLevel { get; set; }

        public int? status { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? createTime { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updateTime { get; set; }

        public int? createUser { get; set; }

        public int? updateUser { get; set; }
    }
}
