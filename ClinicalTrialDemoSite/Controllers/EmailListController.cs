using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClinicalTrialDemoSite.Data;
using ClinicalTrialDemoSite.Models;

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
