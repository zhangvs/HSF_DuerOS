namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.android_user_info")]
    public partial class android_user_info
    {
        public int id { get; set; }

        public int customerId { get; set; }

        [Required]
        [StringLength(50)]
        public string imei { get; set; }

        public int? custUserId { get; set; }

        public long? updateTime { get; set; }
    }
}
