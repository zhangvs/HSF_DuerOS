namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_model_format_item")]
    public partial class t_device_model_format_item
    {
        public int id { get; set; }

        public int? modelFormatId { get; set; }

        public int? itemId { get; set; }

        [StringLength(500)]
        public string abilityIds { get; set; }

        public int? showStatus { get; set; }

        [StringLength(200)]
        public string showName { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }

        public int? canAdminOper { get; set; }

        [StringLength(512)]
        public string remark { get; set; }

        [StringLength(10)]
        public string operStatus { get; set; }

        public int? isCheck { get; set; }

        [StringLength(512)]
        public string manageShowDataName { get; set; }
    }
}
