using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpangenbergProject.Models.Customer
{
    public class CustomerModel : Controller
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(12)]
        public int personalNumber { get; set; }
        public string email { get; set; }
        public DateTime dtm { get; set; }
    }
}
