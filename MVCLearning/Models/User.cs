using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLearning.Models
{
    //Preventing Mass Assignment when using Model binders: Method 3 (Applying "BindAttribute" to Class)
    [Bind(Exclude = "IsAdmin")]

    ////Model Binder Customization: Method 3 (Applying "ModelBinderAttribute" to Class)
    //[ModelBinder(typeof(Binders.PersianDateModelBinder))]
    public class User
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string Password { set; get; }

        public DateTime AddDate { set; get; }

        //Preventing Mass Assignment when using Model binders: Method 4 (Applying "ReadOnlyAttribute" to Property)
        [ReadOnly(true)]
        public bool IsAdmin { set; get; }
    }
}