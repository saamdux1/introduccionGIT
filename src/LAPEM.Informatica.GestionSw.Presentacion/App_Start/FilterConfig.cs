using System.Web;
using System.Web.Mvc;

namespace LAPEM.Informatica.GestionSw.Presentacion
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
