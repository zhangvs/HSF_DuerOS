namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_project_extra_device")]
    public partial class t_project_extra_device
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string deviceNo { get; set; }

        public int projectId { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string model { get; set; }

        [StringLength(50)]
        public string factory { get; set; }

        [StringLength(200)]
        public string direction { get; set; }

        public int? status { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? createTime { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updateTime { get; set; }

        public int? createUser { get; set; }

        public int? updateUser { get; set; }
    }
}
