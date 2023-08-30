using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees insurees)
        {
            if (ModelState.IsValid)
            {
                insurees.Quote = 50m;
                if(DateTime.Now.Year - insurees.DateOfBirth.Year <= 18)
                {
                    insurees.Quote += 100;
                }
                if(DateTime.Now.Year - insurees.DateOfBirth.Year >= 19 && DateTime.Now.Year - insurees.DateOfBirth.Year <= 25)
                {
                    insurees.Quote += 50;
                }
                if (DateTime.Now.Year - insurees.DateOfBirth.Year >= 26)
                {
                    insurees.Quote += 25;
                }
                if (DateTime.Now.Year - insurees.CarYear <= 2000)
                {
                    insurees.Quote += 25;
                }
                if (DateTime.Now.Year - insurees.CarYear >= 2015)
                {
                    insurees.Quote += 25;
                }
                if (insurees.CarMake = "Porsche" && insurees.CarModel = "911 Carrera")
                {
                    insurees.Quote += 50;
                }
                if(insurees.SpeedingTickets >= 1)
                {
                    insurees.Quote += 10;
                }
                insurees.DUI = true;
                {
                    insurees.Quote += 25;
                }
                insurees.CoverageType = Full Coverage;
                {
                    insurees.Quote += 50;
                }



                 db.Insurees.Add(insurees);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insurees);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees insurees)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insurees).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insurees);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurees insurees = db.Insurees.Find(id);
            db.Insurees.Remove(insurees);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
