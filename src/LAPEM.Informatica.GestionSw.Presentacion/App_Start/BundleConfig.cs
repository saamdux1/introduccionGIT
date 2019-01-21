using System.Web;
using System.Web.Optimization;

namespace LAPEM.Informatica.GestionSw.Presentacion
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts")              //.Include("~/app/scripts/jquery.min.js")
              
              .Include("~/app/Scripts/jquery-3.3.1.js")
              .Include("~/app/Scripts/bootstrap.js")

            );

            bundles.Add(new StyleBundle("~/bundles/styles")
                .Include("~/app/Css/bootstrap.css")
            );
        }
    }
}
