﻿using DinnerApp.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DinnerApp.Controllers
{
    public class EntreeController : Controller
    {
        // GET: Entree
        [HttpGet]
        public ActionResult Index()
        {
            var entrees = EntreeManager.GetAll();
            return View(entrees);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            try
            {
                var entree = EntreeManager.GetAll().First(x => x.ID == id);
                return View(entree);
            }
            catch (Exception)
            {

                TempData["ErrorMessage"] = "No Entree with ID" + id.ToString() + " exists.";
                return RedirectToAction("Index");
            }
        }
    }
}