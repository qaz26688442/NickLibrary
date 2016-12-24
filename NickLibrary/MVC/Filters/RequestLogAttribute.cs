using NickLibrary.MVC.Interfaces;
using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NickLibrary.MVC.Filters
{
    public class RequestLogAttribute : ActionFilterAttribute, LogRepository
    {
        private void Log(string stageName, RouteData routeData, HttpContextBase httpContext)
        {
            string userIP = httpContext.Request.UserHostAddress;
            string userName = httpContext.User.Identity.Name;
            string requestType = httpContext.Request.RequestType;
            string controller = routeData.Values["controller"].ToString();
            string action = routeData.Values["action"].ToString();
            string reqData = GetRequestData(httpContext);

            //實作儲存機制
            Save();
        }

        //Aux method to grab request data
        private string GetRequestData(HttpContextBase context)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < context.Request.QueryString.Count; i++)
            {
                sb.AppendFormat("QueryString Key={0}, Value={1}<br/>", context.Request.QueryString.Keys[i], context.Request.QueryString[i]);
            }

            for (int i = 0; i < context.Request.Form.Count; i++)
            {
                sb.AppendFormat("Form Key={0}, Value={1}<br/>", context.Request.Form.Keys[i], context.Request.Form[i]);
            }

            return sb.ToString();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("test", filterContext.RouteData, filterContext.HttpContext);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}