using System.Web.Mvc;
using MVCLearning.Models;

namespace MVCLearning.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(); //Shows the login page
        }

        [HttpPost]
        public ActionResult LoginResult()
        {
            string name = Request.Form["Name"];
            string password = Request.Form["Password"];

            if (name == "Vahid" && password == "123")
                ViewBag.Message = "Succeeded";
            else
                ViewBag.Message = "Failed";

            return View("Result");
        }

        [HttpPost]
        [ActionName("LoginResultWithParams")]
        public ActionResult LoginResult(string name, string password)
        {
            if (name == "Vahid" && password == "123")
                ViewBag.Message = "Succeeded";
            else
                ViewBag.Message = "Failed";

            return View("Result");
        }

        [HttpPost]
        public ActionResult Login(Account account)
        {
            if (account.Name == "Vahid" && account.Password == "123")
                ViewBag.Message = "Succeeded";
            else
                ViewBag.Message = "Failed";

            return View("Result");
        }
    }
}