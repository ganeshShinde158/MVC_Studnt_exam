﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Studnt_exam.Areas.AdminArea.Controllers
{
    public class DashboardController : Controller
    {
        // GET: AdminArea/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}