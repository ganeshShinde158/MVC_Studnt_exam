using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Studnt_exam.Models;
namespace MVC_Studnt_exam.Areas.AdminArea.Controllers
{
    public class TopicController : Controller
    {
        ExamdbsEntities db;
        public TopicController()
        {
            db = new ExamdbsEntities();
        }
        // GET: AdminArea/Topic
        public ActionResult Index()
        {
            List<tblTopic> lst = db.tblTopics.ToList();
            return View(lst);
        }
        public JsonResult GetTopic()
        {
            List<tblTopic> topicList = new List<tblTopic>();

            foreach (tblTopic c in db.tblTopics.ToList())
            {
                tblTopic tc = new tblTopic()
                {
                    Topic_id = c.Topic_id,
                    Topic_name = c.Topic_name,

                };

                topicList.Add(tc);
            }

            return Json(topicList, JsonRequestBehavior.AllowGet);
        }
        public string AddTopicData(tblTopic st)
        {
            db.tblTopics.Add(st);
            db.SaveChanges();
            return "Topic Added Successfully";

        }
    }
}