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
            using (InsuranceEntities db = new InsuranceEntities())
            {
                foreach (var insuree in db.Insurees)
                {
                    GetQuote(insuree);
                }
                db.SaveChanges();
                return View(db.Insurees.ToList());
            }
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

        // GET: Insuree/Admin
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
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
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
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

        public ActionResult GetQuote(Insuree insuree)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                decimal quote = 50.00M;

                //adjust quote for age of insuree
                if (insuree.DateOfBirth > DateTime.Now.AddYears(-18))
                {
                    quote += 100.00M;
                }
                else if (insuree.DateOfBirth > DateTime.Now.AddYears(-26) & insuree.DateOfBirth < DateTime.Now.AddYears(-18))
                {
                    quote += 50.00M;
                }
                else
                {
                    quote += 25.00M;
                }

                // check if car year is in bounds
                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                    quote += 25.00M;
                }

                //check if car make is a porsche
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    quote += 25.00M;
                    if (insuree.CarModel.ToLower() == "911 carrera")
                    {
                        quote += 25.00M;
                    }
                }

                //increases quote for each speeding ticket owned by insuree
                quote += insuree.SpeedingTickets * 10;

                //checks for dui, adds 25% to the total
                if (insuree.DUI == true)
                {
                    quote *= 1.25M;
                }

                //checks coverage type, adds 50% to the total
                if (insuree.CoverageType)
                {
                    quote *= 1.5M;
                }

                insuree.Quote = quote;
                return RedirectToAction("Index");
            }

        }
    }
}
