using System.Web;
using System.Web.Optimization;

namespace KanbWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bower_components/metisMenu").Include(
                       "~/bower_components/metisMenu/dist/metisMenu.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/dist/js").Include(
                       "~/dist/js/sb-admin-2.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-united.css",
                      "~/Content/site.css"));

            // ADMIN TEMPLATE
            
            bundles.Add(new StyleBundle("~/bower_components/bootstrap").Include(
                      "~/bower_components/bootstrap/dist/css/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/bower_components/metisMenu1").Include(
                      "~/bower_components/metisMenu/dist/metisMenu.min.css"));

            bundles.Add(new StyleBundle("~/dist/css").Include(
                      "~/dist/css/sb-admin-2.css"));

            bundles.Add(new StyleBundle("~/bower_components/font-awesome").Include(
                      "~/bower_components/font-awesome/css/font-awesome.min.css"));
        
        }
    }
}
