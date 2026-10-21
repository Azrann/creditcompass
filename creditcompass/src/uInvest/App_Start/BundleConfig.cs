using System.Web;
using System.Web.Optimization;

namespace uInvest
{
    public class BundleConfig
    {
        // Para obtener más información acerca de Bundling, consulte http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/base").Include(
                "~/Scripts/Libraries/jquery.js",
                "~/Scripts/Libraries/bootstrap.js",
                "~/Scripts/Libraries/holder.js",
                 "~/Scripts/Libraries/transition.js",
                 "~/Scripts/Libraries/collapse.js"
                ));

            bundles.Add(new StyleBundle("~/content/themes/base/cat").Include(
                       "~/Content/bootstrap.css",
                       "~/Content/themes/bootstrap-theme.css"));

        }
    }
}