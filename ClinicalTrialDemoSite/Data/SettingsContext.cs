using System.Data.Entity;
using ClinicalTrialDemoSite.EFModels;

namespace ClinicalTrialDemoSite.Data
{
    public class SettingsContext : DbContext
    {
        public DbSet<SettingsModel> Settings { get; set; }
    }

}
