﻿using GBAdmin.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GBAdmin.Controllers
{
    public class DashboardController : Controller
    {
        [Route("Dashboard", Name = RouteNames.Dashboard)]
        public ActionResult Index()
        {
            return View();
        }

        

    }
}