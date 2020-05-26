namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_product")]
    public partial class t_product
    {
        public int id { get; set; }

        public int? customerId { get; set; }

        public int? publicId { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [Column(TypeName = "char")]
        [StringLength(10)]
        public string qrcode { get; set; }

        public long? createTime { get; set; }

        public long? lastUpadateTime { get; set; }
    }
}
