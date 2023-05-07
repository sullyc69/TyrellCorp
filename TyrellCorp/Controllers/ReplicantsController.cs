﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TyrellCorp.Controllers
{
    public class ReplicantsController : Controller
    {


        // GET: ReplicantsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReplicantsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReplicantsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReplicantsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReplicantsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReplicantsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReplicantsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReplicantsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
