﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Default()
        {
            return View();
        }
        public ActionResult Demo()
        {
            return View();
        }
    }
}