using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace CurrencyProject.WebAPI.Filters
{
    public class LogAttribute : ActionFilterAttribute
    {
        private log4net.ILog log = null;
        public LogAttribute()
        {
            log4net.Config.BasicConfigurator.Configure();
            log = log4net.LogManager.GetLogger("Controller");
        }
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            log.Info(string.Format("Action Method {0} executing at {1} Action Arguments {2}",
                                                                                             actionContext.ActionDescriptor.ActionName,
                                                                                             DateTime.Now.ToShortDateString(),
                                                                                             string.Join(" / ", actionContext.ActionArguments.Select(kvp => string.Format("Key={0}, Values={1}", kvp.Key, kvp.Value)))
                                                                                             ));
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            log.Info(string.Format("Action Method {0} executed at {1}", actionExecutedContext.ActionContext.ActionDescriptor.ActionName, DateTime.Now.ToString()));
        }
    }
}