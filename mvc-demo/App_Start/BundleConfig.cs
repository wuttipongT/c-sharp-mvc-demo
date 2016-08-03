using System.Web;
using System.Web.Optimization;

namespace WMS_Web_SCG_CDMA
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                       // "~/Scripts/jQuery-2.2.0.min",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/jquery-ui-1.11.4.min.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/select2.full.min.js",
                      //Morris.js charts
                      "~/Scripts/raphael-min.js",
                      "~/Scripts/morris.js",
                      //!--Sparkline-- >
                      "~/Scripts/jquery.sparkline.min.js",
                      //<!-- jvectormap -->
                      "~/Scripts/jquery-jvectormap-1.2.2.min.js",
                      "~/Scripts/jquery-jvectormap-world-mill-en.js",
                      //<!-- jQuery Knob Chart -->
                      "~/Scripts/jquery.knob.js",
                      //<!-- daterangepicker -->
                      "~/Scripts/moment.min.js",
                      "~/Scripts/daterangepicker.js",
                      //!--datepicker-- >
                      "~/Scripts/bootstrap-datepicker.js",
                      //<!-- Bootstrap WYSIHTML5 -->
                      "~/Scripts/bootstrap3-wysihtml5.all.js",
                      //<!-- Slimscroll -->
                      "~/Scripts/jquery.slimscroll.min.js",
                      "~/Scripts/icheck.min.js",
                      //< !--FastClick-- >
                      "~/Scripts/fastclick.js",
                      //  < !--AdminLTE App-- >
                      "~/Scripts/app.js",
                      "~/Scripts/dashboard.js",
                      "~/Scripts/demo.js",
                      "~/Scripts/jquery.ba-hashchange.min.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/nanobar.min.js")
                      );

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/AdminLTE.css",
                      "~/Content/_all-skins.css",
                      "~/Content/blue.css",
                      "~/Content/morris.css",
                      "~/Content/jquery-jvectormap-1.2.2.css",
                      "~/Content/datepicker3.css",
                      "~/Content/daterangepicker-bs3.css",
                      "~/Content/bootstrap3-wysihtml5.css",
                      "~/Content/icheckall.css",
                      "~/Content/select2.min.css",
                      "~/Content/site.css"));
        }
    }
}
