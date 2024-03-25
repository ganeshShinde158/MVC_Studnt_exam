using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Studnt_exam.Models;
namespace MVC_Studnt_exam.Areas.StudentArea.Controllers
{
    public class UserController : Controller
    {
        ExamdbsEntities db;

        public UserController()
        {
            db = new ExamdbsEntities();
        }
        // GET: StudentArea/User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string email_address, string password)

        {
            tblStudent_details sd = db.tblStudent_details.ToList().FirstOrDefault(e => e.Email_address.Equals(email_address) && e.password.Equals(password));
            if (sd != null)
            {
                Session["student_id"] = sd.Student_id;
                Session["student"] = sd;
                Session.Timeout = 10;
                return Redirect("/StudentArea/Exam/Index");
            }
            else
            {
                ViewBag.msg = "Invalid Email Address";
                return View();

            }
        }
    }
}