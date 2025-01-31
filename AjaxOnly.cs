// Create a file in the name AjaxOnlyAttribute, paste the code below.
// Remember to change the namespace "MySite".Models


using System.Web.Mvc;

namespace MySite.Models
{
    public class AjaxOnlyAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                if (!filterContext.HttpContext.Request.IsAjaxRequest())
                    filterContext.HttpContext.Response.Redirect("/Error/NotFound/");
            }
        }
}