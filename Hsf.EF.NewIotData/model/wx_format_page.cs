namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.wx_format_page")]
    public partial class wx_format_page
    {
        public int id { get; set; }

        public int? formatId { get; set; }

        public int? pageNo { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(200)]
        public string showImg { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }
    }
}
