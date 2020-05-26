namespace Hsf.EF.NewIotData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("newiot.t_device")]
    public partial class t_device
    {
        public int id { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(200)]
        public string manageName { get; set; }

        [StringLength(200)]
        public string mac { get; set; }

        [StringLength(50)]
        public string deviceNo { get; set; }

        [StringLength(200)]
        public string wxDeviceId { get; set; }

        [StringLength(200)]
        public string wxDevicelicence { get; set; }

        [StringLength(300)]
        public string wxQrticket { get; set; }

        [StringLength(200)]
        public string imei { get; set; }

        [StringLength(200)]
        public string imsi { get; set; }

        [StringLength(200)]
        public string saNo { get; set; }

        public int? typeId { get; set; }

        public int? modelId { get; set; }

        [StringLength(50)]
        public string productId { get; set; }

        public int? customerId { get; set; }

        public int? onlineStatus { get; set; }

        public int? bindStatus { get; set; }

        public long? bindTime { get; set; }

        public int? assignStatus { get; set; }

        public int? secondAssignCustomerId { get; set; }

        public long? secondAssignTime { get; set; }

        public long? assignTime { get; set; }

        public int? enableStatus { get; set; }

        public int? workStatus { get; set; }

        public int? powerStatus { get; set; }

        [StringLength(200)]
        public string ip { get; set; }

        [StringLength(50)]
        public string mapGps { get; set; }

        [StringLength(4096)]
        public string speedConfig { get; set; }

        [StringLength(300)]
        public string version { get; set; }

        [StringLength(500)]
        public string location { get; set; }

        public int? iconSelect { get; set; }

        public int? status { get; set; }

        [StringLength(100)]
        public string hardVersion { get; set; }

        [StringLength(100)]
        public string communicationVersion { get; set; }

        [StringLength(100)]
        public string softVersion { get; set; }

        public long? birthTime { get; set; }

        public int? hostStatus { get; set; }

        public int? hostDeviceId { get; set; }

        [StringLength(100)]
        public string childId { get; set; }

        public long? createTime { get; set; }

        public long? lastUpdateTime { get; set; }

        public long? lastOnlineTime { get; set; }

        public int? createUser { get; set; }

        public int? lastUpdateUser { get; set; }

        public int? old { get; set; }
    }
}
