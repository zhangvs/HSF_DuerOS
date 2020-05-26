namespace Hsf.EF.NewIotData
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NewiotDBContext : DbContext
    {
        public NewiotDBContext()
            : base("name=Newiot")
        {
        }

        public virtual DbSet<android_config> android_config { get; set; }
        public virtual DbSet<android_scene> android_scene { get; set; }
        public virtual DbSet<android_scene_img> android_scene_img { get; set; }
        public virtual DbSet<android_user_info> android_user_info { get; set; }
        public virtual DbSet<backend_config> backend_config { get; set; }
        public virtual DbSet<t_customer> t_customer { get; set; }
        public virtual DbSet<t_customer_user> t_customer_user { get; set; }
        public virtual DbSet<t_device> t_device { get; set; }
        public virtual DbSet<t_device_ability> t_device_ability { get; set; }
        public virtual DbSet<t_device_ability_option> t_device_ability_option { get; set; }
        public virtual DbSet<t_device_ability_set> t_device_ability_set { get; set; }
        public virtual DbSet<t_device_ability_set_relation> t_device_ability_set_relation { get; set; }
        public virtual DbSet<t_device_alarm_data> t_device_alarm_data { get; set; }
        public virtual DbSet<t_device_customer_relation> t_device_customer_relation { get; set; }
        public virtual DbSet<t_device_customer_user_relation> t_device_customer_user_relation { get; set; }
        public virtual DbSet<t_device_data_alarm> t_device_data_alarm { get; set; }
        public virtual DbSet<t_device_data_control> t_device_data_control { get; set; }
        public virtual DbSet<t_device_data_sensor> t_device_data_sensor { get; set; }
        public virtual DbSet<t_device_group> t_device_group { get; set; }
        public virtual DbSet<t_device_group_item> t_device_group_item { get; set; }
        public virtual DbSet<t_device_group_scene> t_device_group_scene { get; set; }
        public virtual DbSet<t_device_model> t_device_model { get; set; }
        public virtual DbSet<t_device_model_ability> t_device_model_ability { get; set; }
        public virtual DbSet<t_device_model_ability_option> t_device_model_ability_option { get; set; }
        public virtual DbSet<t_device_model_format> t_device_model_format { get; set; }
        public virtual DbSet<t_device_model_format_item> t_device_model_format_item { get; set; }
        public virtual DbSet<t_device_operlog> t_device_operlog { get; set; }
        public virtual DbSet<t_device_params> t_device_params { get; set; }
        public virtual DbSet<t_device_sensor_stat> t_device_sensor_stat { get; set; }
        public virtual DbSet<t_device_sensor_warn> t_device_sensor_warn { get; set; }
        public virtual DbSet<t_device_team> t_device_team { get; set; }
        public virtual DbSet<t_device_team_item> t_device_team_item { get; set; }
        public virtual DbSet<t_device_team_scene> t_device_team_scene { get; set; }
        public virtual DbSet<t_device_timer> t_device_timer { get; set; }
        public virtual DbSet<t_device_timer_day> t_device_timer_day { get; set; }
        public virtual DbSet<t_device_type> t_device_type { get; set; }
        public virtual DbSet<t_device_type_ability_set> t_device_type_ability_set { get; set; }
        public virtual DbSet<t_device_type_abilitys> t_device_type_abilitys { get; set; }
        public virtual DbSet<t_deviceid_pool> t_deviceid_pool { get; set; }
        public virtual DbSet<t_dict> t_dict { get; set; }
        public virtual DbSet<t_energy_id> t_energy_id { get; set; }
        public virtual DbSet<t_mail_data_device> t_mail_data_device { get; set; }
        public virtual DbSet<t_permission> t_permission { get; set; }
        public virtual DbSet<t_product> t_product { get; set; }
        public virtual DbSet<t_productid_pool> t_productid_pool { get; set; }
        public virtual DbSet<t_project_base_info> t_project_base_info { get; set; }
        public virtual DbSet<t_project_extra_device> t_project_extra_device { get; set; }
        public virtual DbSet<t_project_implement_log> t_project_implement_log { get; set; }
        public virtual DbSet<t_project_job_info> t_project_job_info { get; set; }
        public virtual DbSet<t_project_job_log> t_project_job_log { get; set; }
        public virtual DbSet<t_project_material_info> t_project_material_info { get; set; }
        public virtual DbSet<t_project_material_log> t_project_material_log { get; set; }
        public virtual DbSet<t_project_plan_info> t_project_plan_info { get; set; }
        public virtual DbSet<t_project_plan_info_model> t_project_plan_info_model { get; set; }
        public virtual DbSet<t_project_rule> t_project_rule { get; set; }
        public virtual DbSet<t_role> t_role { get; set; }
        public virtual DbSet<t_role_permission> t_role_permission { get; set; }
        public virtual DbSet<t_statstic_customer_user_live> t_statstic_customer_user_live { get; set; }
        public virtual DbSet<t_user> t_user { get; set; }
        public virtual DbSet<t_user_feedback> t_user_feedback { get; set; }
        public virtual DbSet<t_user_message> t_user_message { get; set; }
        public virtual DbSet<t_user_message_log> t_user_message_log { get; set; }
        public virtual DbSet<wx_bg_img> wx_bg_img { get; set; }
        public virtual DbSet<wx_config> wx_config { get; set; }
        public virtual DbSet<wx_format> wx_format { get; set; }
        public virtual DbSet<wx_format_items> wx_format_items { get; set; }
        public virtual DbSet<wx_format_page> wx_format_page { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<android_config>()
                .Property(e => e.appInfos)
                .IsUnicode(false);

            modelBuilder.Entity<android_config>()
                .Property(e => e.qrcode)
                .IsUnicode(false);

            modelBuilder.Entity<android_config>()
                .Property(e => e.deviceChangePassword)
                .IsUnicode(false);

            modelBuilder.Entity<android_scene>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<android_scene>()
                .Property(e => e.imgsCover)
                .IsUnicode(false);

            modelBuilder.Entity<android_scene>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<android_scene_img>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<android_scene_img>()
                .Property(e => e.imgVideo)
                .IsUnicode(false);

            modelBuilder.Entity<android_scene_img>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<android_user_info>()
                .Property(e => e.imei)
                .IsUnicode(false);

            modelBuilder.Entity<backend_config>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<backend_config>()
                .Property(e => e.logo)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer>()
                .Property(e => e.loginName)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer>()
                .Property(e => e.publicName)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer>()
                .Property(e => e.publicId)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer>()
                .Property(e => e.appid)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer>()
                .Property(e => e.appsecret)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer>()
                .Property(e => e.SLD)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer>()
                .Property(e => e.typeIds)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer>()
                .Property(e => e.modelIds)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer>()
                .Property(e => e.busDirection)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer_user>()
                .Property(e => e.openId)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer_user>()
                .Property(e => e.nickname)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer_user>()
                .Property(e => e.unionid)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer_user>()
                .Property(e => e.headimgurl)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer_user>()
                .Property(e => e.province)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer_user>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<t_customer_user>()
                .Property(e => e.mac)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.manageName)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.mac)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.deviceNo)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.wxDeviceId)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.wxDevicelicence)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.wxQrticket)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.imei)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.imsi)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.saNo)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.productId)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.mapGps)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.speedConfig)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.hardVersion)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.communicationVersion)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.softVersion)
                .IsUnicode(false);

            modelBuilder.Entity<t_device>()
                .Property(e => e.childId)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_ability>()
                .Property(e => e.abilityName)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_ability>()
                .Property(e => e.abilityCode)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_ability>()
                .Property(e => e.dirValue)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_ability>()
                .Property(e => e.paramName)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_ability>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_ability_option>()
                .Property(e => e.abilityId)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_ability_option>()
                .Property(e => e.optionName)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_ability_option>()
                .Property(e => e.optionValue)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_ability_set>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_ability_set>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_alarm_data>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_alarm_data>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_customer_user_relation>()
                .Property(e => e.openId)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_customer_user_relation>()
                .Property(e => e.parentOpenId)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_customer_user_relation>()
                .Property(e => e.deviceId)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_customer_user_relation>()
                .Property(e => e.defineName)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_data_control>()
                .Property(e => e.funcId)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_data_sensor>()
                .Property(e => e.sensorType)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_group>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_group>()
                .Property(e => e.manageUserIds)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_group>()
                .Property(e => e.introduction)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_group>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_group>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_group>()
                .Property(e => e.mapGps)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_group_scene>()
                .Property(e => e.imgVideo)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model>()
                .Property(e => e.modelNo)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model>()
                .Property(e => e.modelCode)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model>()
                .Property(e => e.productId)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model>()
                .Property(e => e.productQrCode)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model>()
                .Property(e => e.iconList)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model>()
                .Property(e => e.helpFileUrl)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model>()
                .Property(e => e.childModelIds)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model_ability>()
                .Property(e => e.definedName)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model_ability>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model_ability_option>()
                .Property(e => e.actualOptionValue)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model_ability_option>()
                .Property(e => e.definedName)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model_format>()
                .Property(e => e.showName)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model_format_item>()
                .Property(e => e.abilityIds)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model_format_item>()
                .Property(e => e.showName)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model_format_item>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model_format_item>()
                .Property(e => e.operStatus)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_model_format_item>()
                .Property(e => e.manageShowDataName)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_operlog>()
                .Property(e => e.funcId)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_operlog>()
                .Property(e => e.funcValue)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_operlog>()
                .Property(e => e.requestId)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_operlog>()
                .Property(e => e.retMsg)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_params>()
                .Property(e => e.typeName)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_params>()
                .Property(e => e.paramDefineName)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_params>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_params>()
                .Property(e => e.configValues)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_team>()
                .Property(e => e.icon)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_team>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_team>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_team>()
                .Property(e => e.manageUserIds)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_team>()
                .Property(e => e.sceneDescription)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_team>()
                .Property(e => e.videoCover)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_team>()
                .Property(e => e.videoUrl)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_team>()
                .Property(e => e.qrcode)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_team>()
                .Property(e => e.adImages)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_team_item>()
                .Property(e => e.manageName)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_team_scene>()
                .Property(e => e.imgVideo)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_timer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_type>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_type>()
                .Property(e => e.typeNo)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_type>()
                .Property(e => e.icon)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_type>()
                .Property(e => e.stopWatch)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_type>()
                .Property(e => e.source)
                .IsUnicode(false);

            modelBuilder.Entity<t_device_type>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<t_deviceid_pool>()
                .Property(e => e.productId)
                .IsUnicode(false);

            modelBuilder.Entity<t_deviceid_pool>()
                .Property(e => e.wxDeviceId)
                .IsUnicode(false);

            modelBuilder.Entity<t_deviceid_pool>()
                .Property(e => e.wxDeviceLicence)
                .IsUnicode(false);

            modelBuilder.Entity<t_deviceid_pool>()
                .Property(e => e.wxQrticket)
                .IsUnicode(false);

            modelBuilder.Entity<t_dict>()
                .Property(e => e.label)
                .IsUnicode(false);

            modelBuilder.Entity<t_dict>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<t_dict>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<t_dict>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<t_energy_id>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_energy_id>()
                .Property(e => e.energyId)
                .IsUnicode(false);

            modelBuilder.Entity<t_energy_id>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<t_energy_id>()
                .Property(e => e.pageId)
                .IsUnicode(false);

            modelBuilder.Entity<t_energy_id>()
                .Property(e => e.pageName)
                .IsUnicode(false);

            modelBuilder.Entity<t_energy_id>()
                .Property(e => e.pageMatchId)
                .IsUnicode(false);

            modelBuilder.Entity<t_mail_data_device>()
                .Property(e => e.mac)
                .IsUnicode(false);

            modelBuilder.Entity<t_permission>()
                .Property(e => e.authKey)
                .IsUnicode(false);

            modelBuilder.Entity<t_permission>()
                .Property(e => e.action)
                .IsUnicode(false);

            modelBuilder.Entity<t_permission>()
                .Property(e => e.authName)
                .IsUnicode(false);

            modelBuilder.Entity<t_product>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_product>()
                .Property(e => e.qrcode)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_base_info>()
                .Property(e => e.projectNo)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_base_info>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_base_info>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_base_info>()
                .Property(e => e.buildAddress)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_base_info>()
                .Property(e => e.gps)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_base_info>()
                .Property(e => e.groupIds)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_base_info>()
                .Property(e => e.imgList)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_extra_device>()
                .Property(e => e.deviceNo)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_extra_device>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_extra_device>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_extra_device>()
                .Property(e => e.factory)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_extra_device>()
                .Property(e => e.direction)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_implement_log>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_implement_log>()
                .Property(e => e.imgList)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_implement_log>()
                .Property(e => e.fileList)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_job_info>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_job_info>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_job_info>()
                .Property(e => e.imgList)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_job_info>()
                .Property(e => e.enableUsers)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_job_info>()
                .Property(e => e.viewUsers)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_job_info>()
                .Property(e => e.workUsers)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_job_log>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_job_log>()
                .Property(e => e.imgList)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_material_info>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_material_info>()
                .Property(e => e.unit)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_plan_info>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_plan_info>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_plan_info>()
                .Property(e => e.enableUsers)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_plan_info_model>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_plan_info_model>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_plan_info_model>()
                .Property(e => e.enableUsers)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_rule>()
                .Property(e => e.monitorValue)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_rule>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_project_rule>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<t_role>()
                .Property(e => e.roleName)
                .IsUnicode(false);

            modelBuilder.Entity<t_role>()
                .Property(e => e.roleDesc)
                .IsUnicode(false);

            modelBuilder.Entity<t_role>()
                .Property(e => e.secondDomain)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.realName)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.nickName)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.telephone)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.openID)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.appId)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.appSecret)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.secondDomain)
                .IsUnicode(false);

            modelBuilder.Entity<t_user>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<t_user_feedback>()
                .Property(e => e.feedbackInfo)
                .IsUnicode(false);

            modelBuilder.Entity<t_user_message>()
                .Property(e => e.topic)
                .IsUnicode(false);

            modelBuilder.Entity<t_user_message>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<t_user_message_log>()
                .Property(e => e.topic)
                .IsUnicode(false);

            modelBuilder.Entity<t_user_message_log>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<wx_bg_img>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<wx_bg_img>()
                .Property(e => e.bgImg)
                .IsUnicode(false);

            modelBuilder.Entity<wx_bg_img>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<wx_config>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<wx_config>()
                .Property(e => e.serviceUser)
                .IsUnicode(false);

            modelBuilder.Entity<wx_config>()
                .Property(e => e.defaultTeamName)
                .IsUnicode(false);

            modelBuilder.Entity<wx_config>()
                .Property(e => e.htmlTypeIds)
                .IsUnicode(false);

            modelBuilder.Entity<wx_config>()
                .Property(e => e.backgroundImg)
                .IsUnicode(false);

            modelBuilder.Entity<wx_config>()
                .Property(e => e.themeName)
                .IsUnicode(false);

            modelBuilder.Entity<wx_config>()
                .Property(e => e.logo)
                .IsUnicode(false);

            modelBuilder.Entity<wx_config>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<wx_config>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<wx_format>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<wx_format>()
                .Property(e => e.htmlUrl)
                .IsUnicode(false);

            modelBuilder.Entity<wx_format>()
                .Property(e => e.icon)
                .IsUnicode(false);

            modelBuilder.Entity<wx_format>()
                .Property(e => e.previewImg)
                .IsUnicode(false);

            modelBuilder.Entity<wx_format>()
                .Property(e => e.typeIds)
                .IsUnicode(false);

            modelBuilder.Entity<wx_format>()
                .Property(e => e.customerIds)
                .IsUnicode(false);

            modelBuilder.Entity<wx_format>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<wx_format>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<wx_format_items>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<wx_format_page>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<wx_format_page>()
                .Property(e => e.showImg)
                .IsUnicode(false);
        }
    }
}
