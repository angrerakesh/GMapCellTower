using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Map.Web.App_Start
{
    public class BundleConfig
    {
        private const string API_KEY = "Map.ApiKey";
        public static void RegisterBundles(BundleCollection bundles)
        {

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //    "~/Content/bootstrap.css",
            //    "~/Content/site.css",
            //    "~/Content/bootstrap-responsive.css"));

            bundles.Add(new ScriptBundle("~/js").Include(
                "~/Assets/js/marker.js"
            ));
        }
    }
}