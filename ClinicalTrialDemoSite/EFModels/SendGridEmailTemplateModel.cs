using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialDemoSite.EFModels
{
    public class SendGridEmailTemplateModel
    {
        public int StudyRank { get; set; }

        public string StudyName { get; set; }

        public string StudyDescription { get; set; }
    }
}
