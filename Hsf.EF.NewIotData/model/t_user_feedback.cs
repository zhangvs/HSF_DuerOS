namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_user_feedback")]
    public partial class t_user_feedback
    {
        public int id { get; set; }

        public int? userId { get; set; }

        public int? deviceId { get; set; }

        [StringLength(200)]
        public string feedbackInfo { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }
    }
}
