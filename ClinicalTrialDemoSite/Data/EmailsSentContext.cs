using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using ClinicalTrialDemoSite.EFModels;

namespace ClinicalTrialDemoSite.Data
{
    public class EmailsSentContext : DbContext
    {
        public DbSet<EmailsSentModel> EmailsSent { get; set; }
    }
}
