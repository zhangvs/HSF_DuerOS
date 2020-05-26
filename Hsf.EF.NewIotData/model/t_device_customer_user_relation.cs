namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_customer_user_relation")]
    public partial class t_device_customer_user_relation
    {
        public int id { get; set; }

        public int? customerId { get; set; }

        [StringLength(100)]
        public string openId { get; set; }

        [StringLength(100)]
        public string parentOpenId { get; set; }

        [StringLength(100)]
        public string deviceId { get; set; }

        [StringLength(400)]
        public string defineName { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
