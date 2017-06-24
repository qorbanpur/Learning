using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLearning.Controllers
{
    public class MenuController : Controller
    {
        [ChildActionOnly]//Availabe just via 'Html.Action' or 'Html.RenderAction' or 'Html.RenderPartial' (Refer: EmployeeList.cshtml)
        public ActionResult ShowMenu(string options)
        {
            return PartialView(viewName: "_ShowMenu", model: options);
        }
    }
}