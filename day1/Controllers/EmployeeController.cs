using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication19.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        [Route("Employee")]
        public ActionResult GetList()
        {
            return View();
        }
        [Route("NewEmployee")]
        public ActionResult AddEmloyee()
        {
            return View();
        }
    }
}