namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_data_control")]
    public partial class t_device_data_control
    {
        public int id { get; set; }

        public int? deviceId { get; set; }

        [StringLength(255)]
        public string funcId { get; set; }

        public int? funcValue { get; set; }

        public long? createTime { get; set; }
    }
}
