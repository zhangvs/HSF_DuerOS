namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_type_abilitys")]
    public partial class t_device_type_abilitys
    {
        public int id { get; set; }

        public int? abilityId { get; set; }

        public int? typeId { get; set; }
    }
}
