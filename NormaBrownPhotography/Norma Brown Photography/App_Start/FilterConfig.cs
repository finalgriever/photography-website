using System.Web;
using System.Web.Mvc;

namespace Norma_Brown_Photography
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
