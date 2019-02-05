using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess
{
    
                                
    public class PatientRepository
    {
        List<Patient> patients = new List<Patient> {
                                                    new Patient {Id=1, Name="Amit" },
                                                    new Patient {Id=2, Name="Kumar" },
                                                    new Patient {Id=3, Name="Saha" }};

        public List<Patient> GetAllPatients()
        {
            return patients;
        }
    }
}
