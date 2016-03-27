using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;
using ConfigurationSample.Configuration;

namespace ConfigurationSample.Controllers
{

    public class HomeController : Controller
    {
        private AzureStorageSettings _settings;
        public HomeController(IOptions<AzureStorageSettings> options)
        {
            _settings = options.Value;
        }

        public IActionResult Index()
        {
            ViewBag.StorageKey = _settings.AzureStorage;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
