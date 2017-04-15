using System.Web;
using System.Web.Optimization;

namespace ShimiTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/mybundle").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-1.12.0.js",
                         "~/Scripts/jquery.validate*",
                          "~/Scripts/modernizr-*",
                           "~/Scripts/bootstrap.js",
                           "~/Scripts/respond.js",
                           "~/Scripts/jquery.unobtrusive-ajax.js",
                           "~/Scripts/students.js"
                        ));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                   "~/Content/jquery-ui.css",
                "~/Content/bootstrap.css",
                    "~/Content/site.css",
                    "~/Content/bootstrap-theme.css"
                    ));

           
            bundles.Add(new ScriptBundle("~/bundles/EditBundle").Include(
                       "~/Scripts/jquery-{version}.js",
                       "~/Scripts/students.js"
                ));

            

  
            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));
        }
    }
}
