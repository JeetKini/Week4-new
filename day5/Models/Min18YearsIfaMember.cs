using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidlysProject.Models
{
    public class Min18YearsIfaMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var  customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsyYouGo) {
                return ValidationResult.Success;
            }
            if(customer.BirthDate==null)
            {
                return new ValidationResult("BirthDate is Required");
            }
            var age=DateTime.Today.Year - customer.BirthDate.Year;
            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer should be atleast 18years  old to go on membership");
        }
    }
}