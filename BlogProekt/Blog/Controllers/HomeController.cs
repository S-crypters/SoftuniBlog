﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // return RedirectToAction("List", "Article");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Desciption";

            return View();
        }
    }
}