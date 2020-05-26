namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_sensor_stat")]
    public partial class t_device_sensor_stat
    {
        public int id { get; set; }

        public int? deviceId { get; set; }

        public int? co2 { get; set; }

        public int? hcho { get; set; }

        public int? pm { get; set; }

        public int? hum { get; set; }

        public int? tvoc { get; set; }

        public int? tem { get; set; }

        public int? nh3 { get; set; }

        public int? anion { get; set; }

        public int? inWaterTem { get; set; }

        public int? outWaterTem { get; set; }

        public long? startTime { get; set; }

        public long? endTime { get; set; }

        public long? insertTime { get; set; }
    }
}
