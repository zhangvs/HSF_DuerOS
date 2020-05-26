namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.wx_format_items")]
    public partial class wx_format_items
    {
        public int id { get; set; }

        public int formatId { get; set; }

        public int? pageId { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        public int? abilityType { get; set; }

        public int? showSelect { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTIme { get; set; }
    }
}
