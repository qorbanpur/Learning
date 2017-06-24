using MVCLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLearning.Controllers
{
    public class HomeController : Controller
    {
        #region Local Variables
        UserInfoViewModel _userInfo = new UserInfoViewModel
        {
            Email = "name@site.com",
            HasRegistered = true,
            LoginProvider = "Sth"
        };

        ManageInfoViewModel _manageInfoViewModel = new ManageInfoViewModel
        {
            Email = "name@site.com",
            LocalLoginProvider = "Local Login Provider"
        }; 
        #endregion

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.Country = "Iran";

            return View(_userInfo);
        }

        public ActionResult List()
        {
            //return View(new ManageInfoViewModel().Logins);
            return View(new Products());
        }

        public ActionResult Details(string id)
        {
            var product = new Products().FirstOrDefault(x => x.ProductNumber == id);

            if (product == null)
                return View("Error");

            return View(product);
        }
    }
}