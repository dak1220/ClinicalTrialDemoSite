using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicalTrialDemoSite.EFModels
{
    public class EmailsSentModel
    {
        [Key]
        public int EmailId { get; set; }

        public string EmailAddress { get; set; }

        public string StudySearchTerm { get; set; }

        public int StudyRank { get; set; }

        public string StudyNCTId { get; set; }

        public DateTime DateEmailSent { get; set; }
    }
}
