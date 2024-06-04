using System.Web;
using System.Web.Mvc;

namespace EmployeeCRUD_EF_cF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
