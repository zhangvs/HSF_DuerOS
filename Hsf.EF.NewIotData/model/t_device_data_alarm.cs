namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_data_alarm")]
    public partial class t_device_data_alarm
    {
        public int id { get; set; }

        public int? deviceId { get; set; }

        public int? indexVal { get; set; }

        public int? type { get; set; }

        public int? value { get; set; }

        public int? dealStatus { get; set; }

        public int? dealTime { get; set; }

        public long? createTime { get; set; }
    }
}
