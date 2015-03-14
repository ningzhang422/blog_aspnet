﻿using BlogSansLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSansLogin.Controllers
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

        [HttpGet]
        public ActionResult AddArticle()
        {
            ViewBag.Title = "Add Article";
            return View();
        }

        [HttpPost]
        public ActionResult AddArticle(Article article)
        {
            ViewBag.Title = "Add Article";
            return View();
        }
    }
}