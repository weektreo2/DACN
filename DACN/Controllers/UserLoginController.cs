﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DACN.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: UserLogin
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
    }
}