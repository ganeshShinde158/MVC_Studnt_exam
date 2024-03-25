using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Studnt_exam.Models;

namespace MVC_Studnt_exam.Areas.AdminArea.Controllers
{
    public class StudentController : Controller
    {
        ExamdbsEntities db;

        public StudentController()
        {
            db = new ExamdbsEntities();
        }
        // GET: AdminArea/Student
        public ActionResult Index()
        {
            List<tblStudent_details> lst = db.tblStudent_details.ToList();
            return View(lst);
        }
        [HttpPost]
        public string AddStudent(tblStudent_details st)
        {
            db.tblStudent_details.Add(st);
            db.SaveChanges();
            return "Student Added Successfully";
        }
    }
}