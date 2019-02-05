using Demo.Business;
using Demo.Entities;
using DemoMvcApplication.Attributes;
using DemoMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMvcApplication.Controllers
{
    public class PatientController : Controller
    {
        PatientManager patientManager = new PatientManager();


        // GET: Patient
        [CustomAuthorize]
        public ActionResult Index()
        {
            List<PatientViewModel> model = new List<PatientViewModel>();
            List<Patient> patients = patientManager.GetAllPatients();
            foreach(Patient p in patients)
            {
                model.Add(new PatientViewModel {Id=p.Id,Name=p.Name });
            }
            return View(model);
        }
    }
}