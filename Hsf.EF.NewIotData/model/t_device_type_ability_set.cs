namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_type_ability_set")]
    public partial class t_device_type_ability_set
    {
        public int id { get; set; }

        public int? typeId { get; set; }

        public int? abilitySetId { get; set; }
    }
}
