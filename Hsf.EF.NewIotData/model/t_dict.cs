namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_dict")]
    public partial class t_dict
    {
        public int id { get; set; }

        public int? customerId { get; set; }

        public int value { get; set; }

        [Required]
        [StringLength(50)]
        public string label { get; set; }

        [Required]
        [StringLength(50)]
        public string type { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public int sort { get; set; }

        [StringLength(255)]
        public string remarks { get; set; }

        public DateTime? createTime { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updateTime { get; set; }

        public int? createUserId { get; set; }

        public int? updateUserId { get; set; }

        public int isDelete { get; set; }
    }
}
