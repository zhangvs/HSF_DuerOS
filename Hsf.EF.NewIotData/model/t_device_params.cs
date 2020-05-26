namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_params")]
    public partial class t_device_params
    {
        public int id { get; set; }

        public int deviceId { get; set; }

        public int abilityId { get; set; }

        [Required]
        [StringLength(20)]
        public string typeName { get; set; }

        [StringLength(20)]
        public string paramDefineName { get; set; }

        [StringLength(200)]
        public string value { get; set; }

        [StringLength(200)]
        public string configValues { get; set; }

        public int sort { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }

        public int? createUserId { get; set; }

        public int? updateUserId { get; set; }

        public int? updateWay { get; set; }
    }
}
