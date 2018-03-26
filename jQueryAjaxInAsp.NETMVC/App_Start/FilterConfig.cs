using System.Web;
using System.Web.Mvc;

namespace jQueryAjaxInAsp.NETMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
