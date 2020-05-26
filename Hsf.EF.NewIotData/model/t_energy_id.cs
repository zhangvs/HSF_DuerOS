namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_energy_id")]
    public partial class t_energy_id
    {
        public int id { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(100)]
        public string energyId { get; set; }

        [StringLength(10)]
        public string type { get; set; }

        [StringLength(100)]
        public string pageId { get; set; }

        [StringLength(20)]
        public string pageName { get; set; }

        [StringLength(100)]
        public string pageMatchId { get; set; }

        public int? status { get; set; }

        public int? createUser { get; set; }

        public long? createTime { get; set; }

        public int? lastUpdateUser { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
