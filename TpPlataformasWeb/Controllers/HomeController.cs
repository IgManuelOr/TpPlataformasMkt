﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TpPlataformasWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ModeloDeNegocios()
        {
            return View();
        }

        public ActionResult PagosySeguridad()
        {
            return View();
        }
        public ActionResult KPIs()
        {
            return View();
        }
        public ActionResult Community()
        {
            return View();
        }
        public ActionResult Plataformas()
        {
            return View();
        }
        public ActionResult Privacidad()
        {
            return View();
        }
        public ActionResult MediaPlanning()
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
    }
}