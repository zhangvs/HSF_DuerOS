namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_customer")]
    public partial class t_customer
    {
        public int id { get; set; }

        public int? parentCustomerId { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(100)]
        public string loginName { get; set; }

        public int? userType { get; set; }

        [StringLength(2000)]
        public string remark { get; set; }

        [StringLength(200)]
        public string publicName { get; set; }

        [StringLength(200)]
        public string publicId { get; set; }

        [StringLength(200)]
        public string appid { get; set; }

        [StringLength(200)]
        public string appsecret { get; set; }

        [StringLength(100)]
        public string SLD { get; set; }

        [StringLength(1000)]
        public string typeIds { get; set; }

        [StringLength(1000)]
        public string modelIds { get; set; }

        [StringLength(2000)]
        public string busDirection { get; set; }

        public int? status { get; set; }

        public int? createUser { get; set; }

        public long? createTime { get; set; }

        public int? lastUpdateUser { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
