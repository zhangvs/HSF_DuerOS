namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_data_sensor")]
    public partial class t_device_data_sensor
    {
        public int id { get; set; }

        public int? deviceId { get; set; }

        [StringLength(20)]
        public string sensorType { get; set; }

        public int? sensorValue { get; set; }

        public long? createTime { get; set; }
    }
}
