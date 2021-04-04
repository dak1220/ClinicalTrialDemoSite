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
    public class EmailListController : Controller
    {
        private readonly ILogger<EmailListController> _logger;

        public EmailListController(ILogger<EmailListController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (var db = new EmailsSentContext())
            {
                EmailsListModel model = new EmailsListModel();
                model.emailsSent = db.EmailsSent.ToList();
                return View(model);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
