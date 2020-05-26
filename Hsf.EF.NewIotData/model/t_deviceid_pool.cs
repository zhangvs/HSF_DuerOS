namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_deviceid_pool")]
    public partial class t_deviceid_pool
    {
        public int id { get; set; }

        public int? customerId { get; set; }

        [StringLength(100)]
        public string productId { get; set; }

        [StringLength(100)]
        public string wxDeviceId { get; set; }

        [StringLength(255)]
        public string wxDeviceLicence { get; set; }

        [StringLength(300)]
        public string wxQrticket { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }

        public int? createUser { get; set; }

        public int? lastUpdateUser { get; set; }
    }
}
