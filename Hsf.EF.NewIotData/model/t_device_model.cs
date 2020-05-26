namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_model")]
    public partial class t_device_model
    {
        public int id { get; set; }

        public int? customerId { get; set; }

        public int? typeId { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(50)]
        public string modelNo { get; set; }

        [StringLength(200)]
        public string modelCode { get; set; }

        [StringLength(100)]
        public string productId { get; set; }

        [StringLength(200)]
        public string productQrCode { get; set; }

        public int? formatId { get; set; }

        public int? androidFormatId { get; set; }

        [StringLength(20)]
        public string version { get; set; }

        [StringLength(200)]
        public string iconList { get; set; }

        [StringLength(1000)]
        public string helpFileUrl { get; set; }

        [StringLength(500)]
        public string remark { get; set; }

        [StringLength(2000)]
        public string childModelIds { get; set; }

        public int? status { get; set; }

        public int? createUser { get; set; }

        public long? createTime { get; set; }

        public int? lastUpdateUser { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
