using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;
using VidlysProject.Models;
using VidlysProject.ViewModels;

namespace VidlysProject.Controllers
{
    public class MovieController : Controller
    {

   
        public ActionResult Index()
        {

            Movie movie = new Movie() { Name = "WorldWar-Z" };

           

            var viewmodel = new RamdomMovieViewModel
            {

                Movie = movie,
               
            };
            return View(viewmodel);



            // return Content("Hello World");
            //return HttpNotFound();
            //  return new EmptyResult();


            // return RedirectToAction("Index","Home",new {page=1,sortby="name"});


        }

        public ActionResult CustomerName()
        {
            var customer = new List<Customer> {

                new Customer{ Name="Jeet Kini"},
                new Customer{ Name="Adnan khan"}
            };
            var viewmodel = new RamdomMovieViewModel
            {


                Customers = customer
            };
            return View(viewmodel);
        }
        public ActionResult Movies()
        {
            ViewBag.Name = "WorldWar-Z";
            return View();
        }
        public ActionResult Details()
        {
            ViewBag.Name = "Jeet Kini";



            return View();

        }
        public ActionResult Edit(int id)
        {

            return Content("id :" + id);
        }
        public ActionResult Index1(int? pageIndex, string sortBy)
        {
            if (pageIndex != 0)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrEmpty(sortBy))
            {
                sortBy = "name";
            }
            return Content(String.Format("pageIndex :{0} sortBy :{1}", pageIndex, sortBy));

        }
    }
}