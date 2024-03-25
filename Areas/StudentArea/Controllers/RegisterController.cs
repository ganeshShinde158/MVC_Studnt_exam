using MVC_Studnt_exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Studnt_exam.Areas.StudentArea.Controllers
{

    public class RegisterController : Controller
    {
        ExamdbsEntities db;

        public RegisterController()
        {
            db = new ExamdbsEntities();
        }
        // GET: StudentArea/Register

        public ActionResult Index()
        {
            var student = new tblStudent_details();
            return View(student);
        }
        [HttpPost]
        public string AddStudent(tblStudent_details st)
        {
            db.tblStudent_details.Add(st);
            db.SaveChanges();
            return "Registration  Successfully";
        }
    }
}

