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
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = calculateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        public static decimal calculateQuote(Insuree insuree)
        {

            decimal rate = 50.0M;

            DateTime now = DateTime.Today;
            var age = now.Year - insuree.DateOfBirth.Year;
            if (age <= 18)
            {
                rate += 100.0M;
            }
            if (age >= 19 && age <= 25)
            {
                rate += 50.0M;
            }
            if (age > 25)
            {
                rate += 25.0M;
            }
            if (insuree.CarYear < 2000)
            {
                rate += 25.0M;
            }
            if (insuree.CarYear > 2015)
            {
                rate += 25.0M;
            }
            if (insuree.CarMake.ToLower() == "porche")
            {
                rate += 25.0M;
            }
            if (insuree.CarMake.ToLower() == "porche" && insuree.CarModel.ToLower() == "911 carrera")
            {
                rate += 25.0M;
            }
            if (insuree.SpeedingTickets > 0)
            {
                rate += (insuree.SpeedingTickets * 10);
            }
            if (insuree.DUI)
            {
                rate += (rate * .25M);
            }
            if (insuree.CoverageType)
            {
                rate += (rate * .5M);
            }
            insuree.Quote = rate;
            return insuree.Quote;

            //using (InsuranceEntities db = new InsuranceEntities())
            //{
            //    var create = new Insuree();
            //    create.FirstName = firstName;
            //    create.LastName = firstName;
            //    create.EmailAddress = emailAddress;
            //    create.DateOfBirth = dateOfBirth;
            //    create.CarYear = carYear;
            //    create.CarMake = carMake;
            //    create.CarModel = carModel;
            //    create.DUI = DUI;
            //    create.SpeedingTickets = speedingTickets;
            //    create.CoverageType = coverageType;
            //    create.Quote = rate;
            //    db.Insurees.Add(create);
            //    db.SaveChanges();
            //}
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
