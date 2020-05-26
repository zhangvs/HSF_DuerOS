namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_mail_data_device")]
    public partial class t_mail_data_device
    {
        public int id { get; set; }

        [StringLength(20)]
        public string mac { get; set; }
    }
}
