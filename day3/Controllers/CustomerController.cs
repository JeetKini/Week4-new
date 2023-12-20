﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlysProject.Models;
using System.Data.Entity;

namespace VidlysProject.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicatoinDbContext _context;

        public CustomerController()
        {
            _context = new ApplicatoinDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var customer = _context.Customers.Include(c=>c.MembershipType).ToList();

            return View(customer);
        }
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        
    }
}