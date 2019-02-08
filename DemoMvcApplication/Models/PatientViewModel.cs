using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMvcApplication.Models
{
    public class PatientViewModel
    {
        public List<PatientDetails> Patients { get; set; }
        public PatientDetails SelectedPatient { get; set; }

    }
}