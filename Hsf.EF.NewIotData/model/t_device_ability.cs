namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device_ability")]
    public partial class t_device_ability
    {
        public int id { get; set; }

        [StringLength(200)]
        public string abilityName { get; set; }

        [StringLength(50)]
        public string abilityCode { get; set; }

        [StringLength(1024)]
        public string dirValue { get; set; }

        public int? writeStatus { get; set; }

        public int? readStatus { get; set; }

        public int? runStatus { get; set; }

        [StringLength(20)]
        public string paramName { get; set; }

        public int? configType { get; set; }

        public int? abilityType { get; set; }

        public int? minVal { get; set; }

        public int? maxVal { get; set; }

        [StringLength(300)]
        public string remark { get; set; }

        public int? status { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }

        public int? createUserId { get; set; }

        public int? updateUserId { get; set; }
    }
}
