using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace VidlysProject.Models
{
    public class ApplicatoinDbContext : DbContext
    {
         public DbSet<Customer> Customers { get; set; }
    }
}