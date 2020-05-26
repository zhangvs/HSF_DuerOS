namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_team_scene")]
    public partial class t_device_team_scene
    {
        public int id { get; set; }

        public int? teamId { get; set; }

        [StringLength(1024)]
        public string imgVideo { get; set; }

        public int? imgVideoMark { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
