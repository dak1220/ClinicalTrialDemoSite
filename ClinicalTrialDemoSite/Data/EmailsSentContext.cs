using System.Data.Entity;
using ClinicalTrialDemoSite.EFModels;

namespace ClinicalTrialDemoSite.Data
{
    public class EmailsSentContext : DbContext
    {
        public DbSet<EmailsSentModel> EmailsSent { get; set; }
    }
}
