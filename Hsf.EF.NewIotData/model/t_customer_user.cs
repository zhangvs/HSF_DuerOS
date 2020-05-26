namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_customer_user")]
    public partial class t_customer_user
    {
        public int id { get; set; }

        public int? customerId { get; set; }

        [StringLength(100)]
        public string openId { get; set; }

        [StringLength(200)]
        public string nickname { get; set; }

        [StringLength(100)]
        public string unionid { get; set; }

        [StringLength(200)]
        public string headimgurl { get; set; }

        public int? sex { get; set; }

        [StringLength(100)]
        public string province { get; set; }

        [StringLength(100)]
        public string city { get; set; }

        [StringLength(100)]
        public string mac { get; set; }

        public int? status { get; set; }

        public long? lastVisitTime { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
