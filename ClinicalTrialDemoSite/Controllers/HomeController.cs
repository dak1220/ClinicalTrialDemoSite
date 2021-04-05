using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClinicalTrialDemoSite.Data;
using ClinicalTrialDemoSite.Models;
using ClinicalTrialDemoSite.EFModels;
using SendGrid;
using SendGrid.Helpers.Mail;
using RestSharp;

namespace ClinicalTrialDemoSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<SendGrid.Response> EmailTrial(FullStudy trial, string searchTerm, int rank, string email)
        {
            string apiKey = "";
            string templateId = "";
            var fromEmail = "";

            var emailSent = new EmailsSentModel();
            emailSent.EmailAddress = email;
            emailSent.StudyRank = rank;
            emailSent.StudySearchTerm = searchTerm;
            emailSent.DateEmailSent = DateTime.UtcNow;

            using (var db = new SettingsContext())
            {
                var dbValues = db.Settings.Find(1);
                if (dbValues != null)
                {
                    apiKey = dbValues.SendGridAPIKey;
                    fromEmail = dbValues.SendGridFromEmail;
                    templateId = dbValues.SendGridTemplateId;
                }
            }
            
            string studyName = "";
            string studyDescription = "";
            try
            {
                studyName = trial.Study.ProtocolSection.IdentificationModule.OfficialTitle;
                studyDescription = trial.Study.ProtocolSection.IdentificationModule.NCTId + " " + trial.Study.ProtocolSection.DescriptionModule.DetailedDescription;
                emailSent.StudyNCTId = trial.Study.ProtocolSection.IdentificationModule.NCTId;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("There was an error with the requested study.");
            }

            //send email using SendGrid
            //see documentation https://sendgrid.com/docs/for-developers/sending-email/v3-csharp-code-example/
            if (apiKey == "")
            {
                return new SendGrid.Response(System.Net.HttpStatusCode.BadRequest, null, null);
            }
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(fromEmail, fromEmail);
            var to = new EmailAddress(email);
            var msg = MailHelper.CreateSingleTemplateEmail(from, to, templateId, null);
            msg.SetTemplateData(new SendGridEmailTemplateModel
            {
                StudyRank = trial.Rank,
                StudyName = studyName,
                StudyDescription = studyDescription
            });
            var response = await client.SendEmailAsync(msg);

            if (!response.IsSuccessStatusCode)
            {
                _logger.LogError("Email was not sent successfully");
            }
            else
            {
                //save this email to the database
                using (var db = new EmailsSentContext())
                {
                    db.EmailsSent.Add(emailSent);
                    db.SaveChanges();
                }
            }

            return response;
        }

        public async Task<List<SendGrid.Response>> SendEmail(List<string> ids, string searchTerm, string email)
        {
            List<SendGrid.Response> responses = new List<SendGrid.Response>();
            List<int> ranks = new List<int>();
            foreach (string id in ids)
            {
                ranks.Add(Int32.Parse(id));
            }

            var client = new RestClient("https://clinicaltrials.gov/api/query/full_studies?expr=" + searchTerm + "&min_rnk=" + ranks.Min() + "&max_rnk=" + ranks.Max() + "&fmt=json");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                ClinicalTrialAPICallModel trials = JsonConvert.DeserializeObject<ClinicalTrialAPICallModel>(response.Content);

                foreach (int rank in ranks)
                {
                    var trial = trials.FullStudiesResponse.FullStudies.Where(x => x.Rank == rank).FirstOrDefault();

                    responses.Add(await EmailTrial(trial, searchTerm, rank, email));
                }
            }
            else
            {
                return responses;
            }

            return responses;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
