namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.wx_config")]
    public partial class wx_config
    {
        public int id { get; set; }

        public int? customerId { get; set; }

        [StringLength(100)]
        public string password { get; set; }

        [StringLength(100)]
        public string serviceUser { get; set; }

        [StringLength(100)]
        public string defaultTeamName { get; set; }

        [StringLength(500)]
        public string htmlTypeIds { get; set; }

        [StringLength(200)]
        public string backgroundImg { get; set; }

        [StringLength(100)]
        public string themeName { get; set; }

        [StringLength(200)]
        public string logo { get; set; }

        [StringLength(100)]
        public string version { get; set; }

        [StringLength(255)]
        public string status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
