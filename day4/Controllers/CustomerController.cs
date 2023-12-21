﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlysProject.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.MappingViews;
using VidlysProject.ViewModels;

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

        public ActionResult CustomerForm()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            var viewModel = new NewCustomerViewModel
            {

                MembershipTypes = membershipTypes
            };


            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index","Customers");
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
           if(customer==null)
                return HttpNotFound();

            var viewModel = new NewCustomerViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()

            };
           return View("CustomerForm",viewModel);   
        }
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        
    }
}