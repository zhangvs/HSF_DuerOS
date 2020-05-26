namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_model_ability")]
    public partial class t_device_model_ability
    {
        public int id { get; set; }

        public int? modelId { get; set; }

        public int? abilityId { get; set; }

        [StringLength(200)]
        public string definedName { get; set; }

        public int? maxVal { get; set; }

        public int? minVal { get; set; }

        public int? isListShow { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }

        public int? canAdminOper { get; set; }

        [StringLength(100)]
        public string remark { get; set; }

        public int? operStatus { get; set; }

        public int? isCheck { get; set; }
    }
}
