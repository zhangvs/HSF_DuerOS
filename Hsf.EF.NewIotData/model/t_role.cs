namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_role")]
    public partial class t_role
    {
        public int id { get; set; }

        [StringLength(100)]
        public string roleName { get; set; }

        [StringLength(64)]
        public string roleDesc { get; set; }

        [StringLength(128)]
        public string secondDomain { get; set; }

        public int? creater { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }

        public int? createUserId { get; set; }

        public int? updateUserId { get; set; }
    }
}
