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
        // GET: Patient
        [CustomAuthorize]
        public ActionResult Index()
        {
            List<PatientDetails> patientsList = new List<PatientDetails>();
           
            patientsList.Add(new PatientDetails
            {
                Address = "Indira Nagar",
                Age = 29,
                Doctor = "Venkatesh",
                Isnormal = "Normal",
                PatientName = "Amit",
                PatientID = 1
            });

            patientsList.Add(new PatientDetails
            {
                Address = "Gandhi Nagar",
                Age = 45,
                Doctor = "Praveen",
                Isnormal = "Abnormal",
                PatientName = "Sachin",
                PatientID = 2
            });
            patientsList.Add(new PatientDetails
            {
                Address = "Kasturi Nagar",
                Age = 60,
                Doctor = "Vivek",
                Isnormal = "AbNormal",
                PatientName = "Nimitha",
                PatientID = 3
            });
            PatientViewModel PatientViewModel = new PatientViewModel();
            PatientViewModel.Patients = patientsList;

            return View(PatientViewModel);
        }

        public ActionResult Detail(int id)
        {
            List<PatientDetails> patientsList = new List<PatientDetails>();
            patientsList.Add(new PatientDetails
            {
                Address = "Indira Nagar",
                Age = 29,
                Doctor = "Venkatesh",
                Isnormal = "Normal",
                PatientName = "Rajesh",
                PatientID = 1
            });

            patientsList.Add(new PatientDetails
            {
                Address = "Gandhi Nagar",
                Age = 35,
                Doctor = "Praveen",
                Isnormal = "Abnormal",
                PatientName = "Verma",
                PatientID = 2
            });
            patientsList.Add(new PatientDetails
            {
                Address = "Kasturi Nagar",
                Age = 35,
                Doctor = "Vivek",
                Isnormal = "AbNormal",
                PatientName = "Ranjan",
                PatientID = 3
            });
            patientsList.Add(new PatientDetails
            {
                Address = "Kasturi Nagar",
                Age = 29,
                Doctor = "Vivek",
                Isnormal = "AbNormal",
                PatientName = "Nikhil",
                PatientID = 4
            });
            patientsList.Add(new PatientDetails
            {
                Address = "Kasturi Nagar",
                Age = 29,
                Doctor = "Vivek",
                Isnormal = "AbNormal",
                PatientName = "Anuja N",
                PatientID = 5
            });
            patientsList.Add(new PatientDetails
            {
                Address = "Kasturi Nagar",
                Age =32,
                Doctor = "Vivek",
                Isnormal = "AbNormal",
                PatientName = "Amrutha",
                PatientID = 5
            });
            PatientViewModel PatientViewModel = new PatientViewModel
            {
                Patients = patientsList,
                SelectedPatient = patientsList.Where(x => x.PatientID == id).First()

            };

            return View("Index", PatientViewModel);
        }

    }
}