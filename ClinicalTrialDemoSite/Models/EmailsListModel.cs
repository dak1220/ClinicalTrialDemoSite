using System.Collections.Generic;
using ClinicalTrialDemoSite.EFModels;

namespace ClinicalTrialDemoSite.Models
{
    public class EmailsListModel
    {
        public List<EmailsSentModel> emailsSent { get; set; }
    }
}
