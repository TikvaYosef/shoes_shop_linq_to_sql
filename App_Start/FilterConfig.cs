using System.Web;
using System.Web.Mvc;

namespace shoes_shop_linq_to_sql
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
