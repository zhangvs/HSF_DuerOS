namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_team")]
    public partial class t_device_team
    {
        public int id { get; set; }

        [StringLength(100)]
        public string icon { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(500)]
        public string remark { get; set; }

        public int? createUserId { get; set; }

        public int? masterUserId { get; set; }

        public int? customerId { get; set; }

        [StringLength(500)]
        public string manageUserIds { get; set; }

        public int? status { get; set; }

        public int? teamStatus { get; set; }

        public int? teamType { get; set; }

        [StringLength(2048)]
        public string sceneDescription { get; set; }

        [StringLength(1024)]
        public string videoCover { get; set; }

        [StringLength(1024)]
        public string videoUrl { get; set; }

        [StringLength(1024)]
        public string qrcode { get; set; }

        [StringLength(1024)]
        public string adImages { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
