﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatASP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int i = 0)
        {
            return View();
        }
    }
}