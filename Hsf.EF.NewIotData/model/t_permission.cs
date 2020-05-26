namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_permission")]
    public partial class t_permission
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(32)]
        public string authKey { get; set; }

        [StringLength(8)]
        public string action { get; set; }

        [StringLength(32)]
        public string authName { get; set; }

        public int? parent { get; set; }
    }
}
