﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlysProject.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter the customer name")]
        [StringLength(200)]
        public string Name { get; set; }
        public bool IsSuscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name="MemberShip Type")]
        public byte MembershipTypeId  { get; set; }
        [Display(Name="Date of Birth")]
        [Min18YearsIfaMember]
        public DateTime BirthDate { get; set; }
    }
}