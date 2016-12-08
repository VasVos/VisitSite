using System.Web;
using System.Web.Optimization;

namespace VisitSite
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //    "~/Scripts/lib/orig/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquerySeq").Include(
                "~/Scripts/lib/orig/jquery-{version}.js",
                "~/Scripts/lib/orig/jquery-sequencer.js",
                "~/Scripts/src/sequencer.js",
                "~/Scripts/src/mainPage.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/MainImages").Include(
                "~/Content/Images/main/*.jpeg"));
        }
    }
}