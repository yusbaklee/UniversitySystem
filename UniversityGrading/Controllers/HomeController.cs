using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityGrading.Models.DB_Models;
using UniversityGrading.Models.View_Models;

namespace UniversityGrading.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Students student)
        {
            try
            {
                var db = new Model1();
                var stud = new Students();
                stud.FirstName = student.FirstName;
                stud.LastName = student.LastName;
                stud.StudentId = student.StudentId;
                stud.MatricNo = student.MatricNo;
                stud.SchoolFees = student.SchoolFees;
                stud.UniType = student.UniType;
                db.SaveChanges();
                return RedirectToAction("SuccessfulReg");
               
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An Error Occured During Registration";
                return View();
            }

        }

        public ActionResult SuccessfulReg()
        {

            return View();
        }
    }
}