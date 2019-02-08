using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMvcApplication.Models
{
    public class PatientDetails
    {
        public int PatientID { get; set; }

        public string PatientName { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public string Doctor { get; set; }

        public string Isnormal { get; set; }

    }
}