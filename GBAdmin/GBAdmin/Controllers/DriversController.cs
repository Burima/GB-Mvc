﻿using GBAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GBAdmin.Controllers
{
    public class DriversController : Controller
    {
        // GET: Drivers/Add
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(DriverViewModel model)
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
    }
}