using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClinicalTrialDemoSite.Data;
using ClinicalTrialDemoSite.EFModels;

namespace ClinicalTrialDemoSite.Controllers
{
    public class SettingsController : Controller
    {
        private readonly ILogger<SettingsController> _logger;

        public SettingsController(ILogger<SettingsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            SettingsModel model = new SettingsModel();

            using (var db = new SettingsContext())
            {
                var dbValues = db.Settings.Find(1);
                model.SendGridAPIKey = dbValues.SendGridAPIKey;
                model.SendGridFromEmail = dbValues.SendGridFromEmail;
                model.SendGridTemplateId = dbValues.SendGridTemplateId;
            }

            return View(model);
        }

        public IActionResult SaveSettings(SettingsModel model)
        {
            using (var db = new SettingsContext())
            {
                SettingsModel settings = new SettingsModel();
                settings.SettingId = 1;
                settings.SendGridAPIKey = model.SendGridAPIKey;
                settings.SendGridFromEmail = model.SendGridFromEmail;
                settings.SendGridTemplateId = model.SendGridTemplateId;
                db.Settings.Add(settings);
                db.SaveChanges();
            }

            return Index();
        }

    }
}
