using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicalTrialDemoSite.EFModels;

namespace ClinicalTrialDemoSite.Models
{
    public class EmailsListModel
    {
        public List<EmailsSentModel> emailsSent { get; set; }
    }
}
