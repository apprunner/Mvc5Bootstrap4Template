using System.Web;
using System.Web.Mvc;

namespace Mvc5Bootstrap4Template
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
