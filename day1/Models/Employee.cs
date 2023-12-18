using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication18.Models
{
    public class Employee
    {
        [Required]
        public string Name  { get; set; }

        [JeetValidation (ErrorMessage ="THE name jeet is mendetory")]
        public string Address { get; set; }

    }
}