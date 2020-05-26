namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.android_config")]
    public partial class android_config
    {
        public int id { get; set; }

        public int customerId { get; set; }

        [StringLength(5000)]
        public string appInfos { get; set; }

        [StringLength(200)]
        public string qrcode { get; set; }

        [StringLength(100)]
        public string deviceChangePassword { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
