using System.Web;
using System.Web.Mvc;

namespace PhamVanKiet_2122110240
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
