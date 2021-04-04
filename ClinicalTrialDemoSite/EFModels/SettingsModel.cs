using System.ComponentModel.DataAnnotations;

namespace ClinicalTrialDemoSite.EFModels
{
    public class SettingsModel
    {
        [Key]
        public int SettingId { get; set; }

        public string SendGridAPIKey { get; set; }

        public string SendGridFromEmail { get; set; }

        public string SendGridTemplateId { get; set; }
    }
}
