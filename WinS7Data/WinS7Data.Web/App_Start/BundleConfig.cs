using System.Web;
using System.Web.Optimization;

namespace WinS7Data.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/jquery.fixedheadertable.js",
                "~/Scripts/jquery.mousewheel.js",
                "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/fixedheadertable").Include(
                      "~/Scripts/jquery.fixedheadertable.js"));

            bundles.Add(new ScriptBundle("~/bundles/mousewheel").Include(
                      "~/Scripts/jquery.mousewheel.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/defaultTheme.css",
                      "~/Content/demo.css",
                      "~/Content/960.css",
                      "~/Content/site.css"));
        }
    }
}
