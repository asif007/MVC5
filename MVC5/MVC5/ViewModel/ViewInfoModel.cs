using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC5.Models;
namespace MVC5.ViewModel
{
    public class ViewInfoModel
    {
        public  IEnumerable<Customer> cus{ get;set;}
        public  IEnumerable<Employee> emp { get; set; }
    }
}