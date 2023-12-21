using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlysProject.Models;

namespace VidlysProject.ViewModels
{
    public class NewCustomerViewModel
    {
        public  IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}