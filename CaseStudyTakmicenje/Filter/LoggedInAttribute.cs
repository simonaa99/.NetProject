using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CaseStudyTakmicenje.Filter
{
    public class LoggedInAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Controller controller = (Controller)context.Controller;
            controller.ViewBag.IsLoggedIn = true;
        }
    }
}
