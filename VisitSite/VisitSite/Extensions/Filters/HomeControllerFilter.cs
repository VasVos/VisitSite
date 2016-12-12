using System.Web.Mvc;

namespace VisitSite.Extensions.Filters
{
    public class HomeControllerFilter: ActionFilterAttribute
    {
        public const string DefaultControllerName = "Home";
        public const string DefaultActionName = "Index";
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.RawUrl != "/" && 
                (string)filterContext.RouteData.Values["controller"] == DefaultControllerName && 
                (string)filterContext.RouteData.Values["action"] == DefaultActionName)
            {
                filterContext.Result = new RedirectResult("~/");
            }
        }
    }
}