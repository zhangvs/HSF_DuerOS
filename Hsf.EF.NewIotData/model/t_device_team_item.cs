namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_team_item")]
    public partial class t_device_team_item
    {
        public int id { get; set; }

        public int? deviceId { get; set; }

        public int? teamId { get; set; }

        [StringLength(100)]
        public string manageName { get; set; }

        public int? userId { get; set; }

        public int? linkAgeStatus { get; set; }

        public int? status { get; set; }

        public long? createTIme { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
