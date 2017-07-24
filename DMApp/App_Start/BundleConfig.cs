using System.Web;
using System.Web.Optimization;

namespace DMApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                                 "~/Scripts/bootstrap.js",
                                 "~/Scripts/respond.js",
                                 "~/Scripts/sidebar-nav.js",
                                 "~/Scripts/jquery.slimscroll.js",
                                 "~/Scripts/waves.js",
                                 "~/Scripts/jquery.waypoints.js",
                                 "~/Scripts/jquery.counterup.min.js",
                                 "~/Scripts/raphael.js",
                                 "~/Scripts/morris.js",
                                 "~/Scripts/chartist.js",
                                 "~/Scripts/chartist-plugin-tooltip.js",
                                 "~/Scripts/moment.js",
                                 "~/Scripts/fullcalendar.js",
                                 "~/Scripts/cal-init.js",
                                 "~/Scripts/custom.min.js",
                                 "~/Scripts/cbpFWTabs.js",
                                 "~/Scripts/jquery.toast.js",
                                 "~/Scripts/jQuery.style.switcher.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/sidebar-nav.css",
                      "~/Content/jquery.toast.css",
                      "~/Content/morris.css",
                      "~/Content/chartist.css",
                      "~/Content/chartist-plugin-tooltip.css",
                      "~/Content/fullcalendar.css",
                      "~/Content/animate.css",
                      "~/Content/style.css",
                      "~/Content/megna-dark.css",
                      "~/Content/spinners.css",
                      "~/Content/site.css"));
        }
    }
}
