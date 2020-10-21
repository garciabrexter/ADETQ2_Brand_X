using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ADETQ2_Brand_X.Models
{
    public class list 
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string studentname { get; set; }

        [Required(ErrorMessage = "Please Enter Your Student #")]
        public string studentno { get; set; }

        [Required(ErrorMessage = "Please Enter Your Age")]
        public int age { get; set; }

        [Required(ErrorMessage = "Please Enter Your Address")]
        public string address { get; set; }
    }
}
