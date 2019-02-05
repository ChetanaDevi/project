using Demo.DataAccess;
using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Business
{
    
    public class PatientManager
    {
        PatientRepository patientRepository = new PatientRepository();
        public List<Patient> GetAllPatients()
        {
            return patientRepository.GetAllPatients();
        }
    }
}
