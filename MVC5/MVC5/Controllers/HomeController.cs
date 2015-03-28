using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5.Models;
namespace MVC5.Controllers
{
    public class HomeController : Controller
    {
        TSQL2012Entities db = new TSQL2012Entities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Aboutdd()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public PartialViewResult All()
        {
            List<Employee> emp = db.Employees.ToList();
            return PartialView("_AjaxPartialView", emp);
        }
        public PartialViewResult Top3()
        {
            List<Employee> emp = new List<Employee>();
            emp = db.Employees.OrderBy(r => r.empid).Take(3).ToList();
            return PartialView("_AjaxPartialView", emp);
        }
        public PartialViewResult Bottom3()
        {
            List<Employee> emp = new List<Employee>();
            emp = db.Employees.OrderByDescending(r => r.empid).Take(3).ToList();
            return PartialView("_AjaxPartialView", emp);
        }
    }
}