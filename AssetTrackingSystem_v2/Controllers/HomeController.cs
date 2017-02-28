﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssetTrackingSystem_v2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PartialMenu();

            return View();
        }

        public ActionResult PartialMenu()
        {
            /* Action is used to load the menu dynamically when traversing from page to page */
            ViewBag.Menu = "Index";

            return PartialView("_PartialMenu");
        }
    }
}