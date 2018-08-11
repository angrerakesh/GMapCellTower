using Map.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Map.Web.Controllers
{
    public class HomeController : Controller
    {
        private const string API_KEY = "Map.ApiKey";
        // GET: Home
        public ActionResult Index()
        {
            MapViewModel model = new MapViewModel();
            model.ApiKey = System.Configuration.ConfigurationManager.AppSettings[API_KEY];
            return View(model);
        }
    }
}