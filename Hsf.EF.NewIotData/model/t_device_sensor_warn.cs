namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_sensor_warn")]
    public partial class t_device_sensor_warn
    {
        public int id { get; set; }

        public int? customerId { get; set; }

        public int? temMax { get; set; }

        public int? temMin { get; set; }

        public int? humMax { get; set; }

        public int? humMin { get; set; }

        public int? pm { get; set; }

        public int? hcho { get; set; }

        public int? tvoc { get; set; }

        public int? co2 { get; set; }
    }
}
