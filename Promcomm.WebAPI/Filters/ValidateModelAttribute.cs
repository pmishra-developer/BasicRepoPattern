namespace Promcomm.WebAPI.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http.Controllers;

    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            Log("OnActionExecuted", actionContext.RouteData);

            if (actionContext.ModelState.IsValid == false)
            {

                actionContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;

            }
        }

        private void Log(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = String.Format("{0}- controller:{1} action:{2}", methodName,
                                                                        controllerName,
                                                                        actionName);
            Console.WriteLine(message);
        }
    }
}
