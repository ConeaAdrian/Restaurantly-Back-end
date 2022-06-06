﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using eUseControl.Web.Extension;
using eUseControl.Models;

namespace eUseControl.Web.Controllers
{
    public class UserController : BaseController
    {
        public ActionResult Index()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Index", "Login");
            }

            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
                Level = user.Level,
                Id = user.Id,
                Email = user.Email
            };

            return View(u);
        }
    }
}