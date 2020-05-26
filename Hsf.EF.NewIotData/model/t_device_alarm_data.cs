namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_alarm_data")]
    public partial class t_device_alarm_data
    {
        public int id { get; set; }

        public int deviceId { get; set; }

        [Required]
        [StringLength(10)]
        public string code { get; set; }

        public int value { get; set; }

        [StringLength(255)]
        public string content { get; set; }

        public int? level { get; set; }

        public DateTime alarmTime { get; set; }

        public long? statusTimeInteval { get; set; }

        public int? status { get; set; }
    }
}
