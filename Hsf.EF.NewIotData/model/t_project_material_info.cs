namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_project_material_info")]
    public partial class t_project_material_info
    {
        public int id { get; set; }

        public int type { get; set; }

        public int projectId { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(20)]
        public string unit { get; set; }

        public int? nums { get; set; }

        public int? status { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? createTime { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updateTime { get; set; }

        public int? createUser { get; set; }

        public int? updateUser { get; set; }
    }
}
