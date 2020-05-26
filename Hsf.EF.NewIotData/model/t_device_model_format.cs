namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_model_format")]
    public partial class t_device_model_format
    {
        public int id { get; set; }

        public int? modelId { get; set; }

        public int? formatId { get; set; }

        public int? pageId { get; set; }

        public int? showStatus { get; set; }

        [StringLength(100)]
        public string showName { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
