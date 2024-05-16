using System.Web;
using System.Web.Mvc;

namespace ASPNET_WebAppMVC_CRUD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
