namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_group")]
    public partial class t_device_group
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        public int? customerId { get; set; }

        public int? masterUserId { get; set; }

        [StringLength(500)]
        public string manageUserIds { get; set; }

        public int? status { get; set; }

        [StringLength(100)]
        public string introduction { get; set; }

        [StringLength(100)]
        public string remark { get; set; }

        [StringLength(100)]
        public string location { get; set; }

        [StringLength(50)]
        public string mapGps { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }

        public int? createUser { get; set; }

        public int? lastUpdateUser { get; set; }
    }
}
