using System.Web;
using System.Web.Mvc;

namespace Assigment1_5101B_WafaMustafa_N01450753
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
