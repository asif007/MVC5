using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5.Models;
using MVC5.ViewModel;
namespace MVC5.Controllers
{
    public class HomeController : Controller
    {
        TSQL2012Entities db = new TSQL2012Entities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Projection()
        {
            var projection = db.Employees.Where(p => p.empid > 5);
           
            return View(projection);
        }
        public ActionResult DisplayImage()
        {
            Employee model = db.Employees.Single(r => r.empid == 3);
            return View(model);
        }
        public ActionResult About()
        {
            ViewInfoModel rrr=new ViewInfoModel();
            //rrr.emp = (from r in db.Employees
            //           join r2 in db.Customers
            //               on r.empid equals r2.custid
            //           select new
            //           {
            //               r.address,
            //               r.birthdate,
            //               firstname = (r.firstname ?? " ") + " " + (r.lastname ?? " "),
            //               r2.country,
            //               r2.contactname
            //           });
           // ViewBag.res=model;
         return View(rrr);
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
            return PartialView("AjaxPartialView", emp);
        }
        public PartialViewResult Top3()
        {
            List<Employee> emp = new List<Employee>();
            emp = db.Employees.OrderBy(r => r.empid).Take(3).ToList();
            return PartialView("AjaxPartialView", emp);
        }
        public PartialViewResult Bottom3()
        {
            List<Employee> emp = new List<Employee>();
            emp = db.Employees.OrderByDescending(r => r.empid).Take(3).ToList();
            return PartialView("AjaxPartialView", emp);
        }
    }
}