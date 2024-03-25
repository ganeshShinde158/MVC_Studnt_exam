using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Studnt_exam.Models;
namespace MVC_Studnt_exam.Areas.AdminArea.Controllers
{
    public class ContentsController : Controller
    {
        ExamdbsEntities db;

        public ContentsController()
        {
            db = new ExamdbsEntities();
        }
        // GET: AdminArea/Contents
        public ActionResult Index()
        {
            List<tblTopic_contents> lst = db.tblTopic_contents.ToList();
            return View(lst);
        }
        public string AddContentData(tblTopic_contents st)
        {
            db.tblTopic_contents.Add(st);
            db.SaveChanges();
            return "Content Added Successfully";

        }
    }
}