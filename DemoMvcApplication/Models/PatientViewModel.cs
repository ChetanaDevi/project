using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMvcApplication.Models
{
    public class PatientViewModel
    {
        [Display(Name = "Patient Number")]
        public int Id { get; set; }
        [Display(Name="Patient Name")]
        public string Name { get; set; }
    }
}