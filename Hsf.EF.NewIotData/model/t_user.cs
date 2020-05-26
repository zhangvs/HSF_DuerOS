namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_user")]
    public partial class t_user
    {
        public int id { get; set; }

        [StringLength(100)]
        public string userName { get; set; }

        [StringLength(100)]
        public string password { get; set; }

        [StringLength(100)]
        public string realName { get; set; }

        [StringLength(100)]
        public string nickName { get; set; }

        [StringLength(16)]
        public string telephone { get; set; }

        [StringLength(50)]
        public string location { get; set; }

        [StringLength(32)]
        public string openID { get; set; }

        public int? roleId { get; set; }

        [StringLength(64)]
        public string appId { get; set; }

        [StringLength(128)]
        public string appSecret { get; set; }

        [StringLength(128)]
        public string secondDomain { get; set; }

        [StringLength(8)]
        public string status { get; set; }

        public int? templateId { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }

        public int? createUser { get; set; }

        public int? lastUpdateUser { get; set; }
    }
}
