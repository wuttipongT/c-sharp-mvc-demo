using System.Web;
using System.Web.Mvc;

namespace WMS_Web_SCG_CDMA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
