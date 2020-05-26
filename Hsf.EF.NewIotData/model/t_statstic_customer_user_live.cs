namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_statstic_customer_user_live")]
    public partial class t_statstic_customer_user_live
    {
        public int id { get; set; }

        public int? customerId { get; set; }

        public int? userLiveCount { get; set; }

        public int? statisticYear { get; set; }

        public int? statisticMonth { get; set; }

        public int? statisticDay { get; set; }

        public int? statisticHour { get; set; }

        public int? statisticMin { get; set; }

        public int? statsticSec { get; set; }
    }
}
