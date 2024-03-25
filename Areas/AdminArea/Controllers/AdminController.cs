using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Studnt_exam.Areas.AdminArea.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminArea/Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string email_address, string password)
        {
            try
            {
                if (email_address == "admin@123" && password == "admin")
                {
                    return Redirect("/AdminArea/ExamDetails/");
                }
                else
                {
                    ViewBag.ErrorMessage = "Invalid credentials!";
                    return View(); 
                }
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = "An error occurred: " + e.Message;
                return View(); 
            }
        }
    }
}