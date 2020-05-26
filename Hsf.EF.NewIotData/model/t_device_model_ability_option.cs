namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_model_ability_option")]
    public partial class t_device_model_ability_option
    {
        public int id { get; set; }

        public int? modelAbilityId { get; set; }

        public int? abilityOptionId { get; set; }

        [StringLength(11)]
        public string actualOptionValue { get; set; }

        [StringLength(200)]
        public string definedName { get; set; }

        public int? defaultValue { get; set; }

        public int? minVal { get; set; }

        public int? maxVal { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }

        public int? canAdminOper { get; set; }
    }
}
