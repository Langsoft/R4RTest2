using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using R4RClientWeb.Models;

namespace R4RClientWeb.Controllers
{
    public class R4RClientController : Controller
    {
        private R4RClientEntities db = new R4RClientEntities();

        //
        // GET: /R4RClient/

        public ActionResult Index()
        {
            var clients = from c in db.R4RClients
                          select c;
            clients = clients.OrderBy(c => c.first_name);
            return View(clients.ToList());
        }

        //
        // GET: /R4RClient/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    R4RClients r4rclients = db.R4RClients.Find(id);
        //    if (r4rclients == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(r4rclients);
        //}

        ////
        //// GET: /R4RClient/Create

        //public ActionResult Create()
        //{
        //    return View();
        //}

        ////
        //// POST: /R4RClient/Create

        //[HttpPost]
        //public ActionResult Create(R4RClients r4rclients)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.R4RClients.Add(r4rclients);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(r4rclients);
        //}

        ////
        //// GET: /R4RClient/Edit/5

        //public ActionResult Edit(int id = 0)
        //{
        //    R4RClients r4rclients = db.R4RClients.Find(id);
        //    if (r4rclients == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(r4rclients);
        //}

        ////
        //// POST: /R4RClient/Edit/5

        //[HttpPost]
        //public ActionResult Edit(R4RClients r4rclients)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(r4rclients).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(r4rclients);
        //}

        ////
        // GET: /R4RClient/Delete/5

        public ActionResult Delete(int id = 0)
        {
            R4RClients r4rclients = db.R4RClients.Find(id);
            if (r4rclients == null)
            {
                return HttpNotFound();
            }
            return View(r4rclients);
        }

        //
        // POST: /R4RClient/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            R4RClients r4rclients = db.R4RClients.Find(id);
            db.R4RClients.Remove(r4rclients);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}