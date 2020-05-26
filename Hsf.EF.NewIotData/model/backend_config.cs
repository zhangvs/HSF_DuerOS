namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.backend_config")]
    public partial class backend_config
    {
        public int id { get; set; }

        public int? customerId { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(200)]
        public string logo { get; set; }

        public int? type { get; set; }

        public int? enableStatus { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
