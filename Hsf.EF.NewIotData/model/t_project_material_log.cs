namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_project_material_log")]
    public partial class t_project_material_log
    {
        public int id { get; set; }

        public int type { get; set; }

        public int? jobLogId { get; set; }

        public int materialId { get; set; }

        public int handerNums { get; set; }

        public int currentNums { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? createTime { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updateTime { get; set; }

        public int? createUser { get; set; }

        public int? updateUser { get; set; }
    }
}
