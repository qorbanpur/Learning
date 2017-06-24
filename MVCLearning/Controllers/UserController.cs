using MVCLearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLearning.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var usersList = new Users().CreateInMemoryDataSource();
            return View(usersList); // Shows the Index view.
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var user = new Users().CreateInMemoryDataSource().FirstOrDefault(x => x.Id == id);
            if (user == null)
                return View("Error");
            return View(user); // Shows the Details view.
        }

        [HttpGet]
        public ActionResult Create()
        {
            var user = new User { AddDate = DateTime.Now };
            return View(user); // Shows the Create view.
        }

        [HttpPost]
        ////Model Binder Customization: Method 2 (Applying "ModelBinderAttribute" to the Argument of Action)
        //public ActionResult Create([ModelBinder(typeof(Binders.PersianDateModelBinder))]User user)
        public ActionResult Create(User user)
        {
            if (this.ModelState.IsValid)
            {
                // todo: Add record
                return RedirectToAction("Index");
            }
            else
            {
                this.ModelState.AddModelError(string.Empty, "Invalid Date!");
            }

            return View(user); // Shows the Create view again.
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var user = new Users().CreateInMemoryDataSource().FirstOrDefault(x => x.Id == id);
            if (user == null)
                return View("Error");
            return View(user); // Shows the Edit view.
        }

        [HttpPost]
        //Preventing Mass Assignment when using Model binders
        //Method 1: Applying "BindAttribute" to Action
        public ActionResult Edit([Bind(Include = "Name, Password")]User user)
        {
            //if (this.ModelState.IsValid)
            //{
            //    // todo: Edit record
            //    return RedirectToAction("Index");
            //}

            //Method 2: Manually model binding using built-in "UpdateModel" and "TryUpdateModel" Methods
            if (TryUpdateModel(user, includeProperties: new[] { "Name", "Password" }))
            {
                // todo: Edit record
                return RedirectToAction("Index");
            }

            return View(user); // Shows the Edit view again.
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            // todo: Delete record
            return RedirectToAction("Index");
        }
    }
}