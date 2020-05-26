namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_user_message_log")]
    public partial class t_user_message_log
    {
        public int id { get; set; }

        public int userId { get; set; }

        [Required]
        [StringLength(20)]
        public string topic { get; set; }

        [StringLength(200)]
        public string description { get; set; }

        public int? status { get; set; }

        public int? readStatus { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? createTime { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updateTime { get; set; }

        public int? createUser { get; set; }

        public int? updateUser { get; set; }
    }
}
