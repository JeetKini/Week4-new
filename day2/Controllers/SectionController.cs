using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication19.Controllers
{
    public class SectionController : Controller
    {
        // GET: Section
        public ActionResult Index()
        {
            return View("Index","Sec");
        }
    }
}