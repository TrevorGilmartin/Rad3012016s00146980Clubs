using System.Web;
using System.Web.Mvc;

namespace Rad3012016s00146980Clubs
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
