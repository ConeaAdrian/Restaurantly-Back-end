using System.Web.Optimization;

namespace eUseControl.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)


        {
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Content/bootstrap.min.css" ));

            bundles.Add(new StyleBundle("~/bundles/animate.min/css").Include("~/Content/animate.min.css" ));

            bundles.Add(new StyleBundle("~/bundles/aos/css").Include("~/Content/aos.css" ));

            bundles.Add(new StyleBundle("~/bundles/bootstrap.min/css").Include("~/Content/bootstrap.min.css" ));

            bundles.Add(new StyleBundle("~/bundles/bootstrap-icons/css").Include("~/Content/bootstrap-icons.css" ));

            bundles.Add(new StyleBundle("~/bundles/glightbox.min/css").Include("~/Content/glightbox.min.css"));

            bundles.Add(new StyleBundle("~/bundles/swiper-bundle.min/css").Include("~/Content/swiper-bundle.min.css"));

            bundles.Add(new StyleBundle("~/bundles/style/css").Include("~/Content/style.css"));




            bundles.Add(new ScriptBundle("~/bundles/aos/js").Include("~/Scripts/aos.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap.bundle.min/js").Include("~/Scripts/bootstrap.bundle.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/glightbox.min/js").Include("~/Scripts/glightbox.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/isotope.pkgd.min/js").Include("~/Scripts/isotope.pkgd.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/validate/js").Include("~/Scripts/validate.js"));
            bundles.Add(new ScriptBundle("~/bundles/swiper-bundle.min/js").Include("~/Scripts/swiper-bundle.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/main/js").Include("~/Scripts/main.js"));

        }
    }
}