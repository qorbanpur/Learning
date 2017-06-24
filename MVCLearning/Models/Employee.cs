using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLearning.Models
{
    public class Employee
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { set; get; }

        [DisplayFormat(NullDisplayText = "-")]
        public string Name { set; get; }

        [DisplayName("Annual Salary ($)")]
        [DisplayFormat(DataFormatString = "{0:n}", ApplyFormatInEditMode = true)]
        public decimal Salary { set; get; }

        [DataType(DataType.Password)]
        public string Password { set; get; }

        [DataType(DataType.MultilineText)]
        public string Address { set; get; }

        [DisplayName("Gender")]
        [UIHint("GenderOptions")]//http://www.dotnettips.info/post/816/asp-net-mvc-12??
        //[UIHint("Enum")]//http://www.dotnettips.info/post/816/asp-net-mvc-12??
        public bool IsMale { set; get; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime AddDate { set; get; }

        [ReadOnly(true)]
        public bool IsAdmin { set; get; }
    }
}