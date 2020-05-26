namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_operlog")]
    public partial class t_device_operlog
    {
        public int id { get; set; }

        public int? deviceId { get; set; }

        [StringLength(11)]
        public string funcId { get; set; }

        [StringLength(255)]
        public string funcValue { get; set; }

        [StringLength(33)]
        public string requestId { get; set; }

        public int? dealRet { get; set; }

        public long? responseTime { get; set; }

        public int? operUserId { get; set; }

        public int? operType { get; set; }

        [StringLength(255)]
        public string retMsg { get; set; }

        public long? createTime { get; set; }
    }
}
