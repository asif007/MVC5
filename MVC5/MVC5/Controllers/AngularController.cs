using MVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class AngularController : Controller
    {
     
        public ActionResult Index()
        {
            ViewModel = "";
            return View();
        }
        public JsonResult GetAllDataFromTable()
        {
            Customer c = null;
            using (TSQL2012Entities db = new TSQL2012Entities()) {
                c = db.Customers.OrderByDescending(r => r.custid).Take(1).FirstOrDefault();
            }
            return new JsonResult { Data = c, JsonRequestBehavior=JsonRequestBehavior.AllowGet };
        }
        public ActionResult Part2()
        {
            return View();
        }
	}
}