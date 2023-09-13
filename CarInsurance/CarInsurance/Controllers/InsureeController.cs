using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CarInsurance.Models;
using Microsoft.VisualBasic;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities2 db = new InsuranceEntities2();

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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
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

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        public decimal CalculateQuote(Insuree insuree) { 
            decimal baseQuote = 50;

            int age = (int)DateAndTime.DateDiff(DateInterval.Year, insuree.DateOfBirth, DateTime.Now);

            if (age <= 18) {
                baseQuote += 100;
            } else if (age <= 25) {
                baseQuote += 50;
            } else {
                baseQuote += 25;
            }

            int carYear = insuree.CarYear;

            if (carYear < 2000 || carYear > 2015) {
                baseQuote += 25;
            }

            if (insuree.CarMake.Equals("Porsche")) {
                baseQuote += 25;
                if (insuree.CarModel.Equals("911 Carrera")) {
                    baseQuote += 25;
                }
            }

            baseQuote += insuree.SpeedingTickets * 10;

            if (insuree.DUI) baseQuote += (baseQuote / 4);

            if (insuree.CoverageType) baseQuote += (baseQuote / 2);

            return baseQuote;
        }

        public decimal CalculateQuote(DateTime dob, int carYear, String carMake, String carModel, int tickets, bool dui, bool full) {
            decimal baseQuote = 50;

            int age = (int)DateAndTime.DateDiff(DateInterval.Year, dob, DateTime.Now);

            if (age <= 18) {
                baseQuote += 100;
            } else if (age <= 25) {
                baseQuote += 50;
            } else {
                baseQuote += 25;
            }

            if (carYear < 2000 || carYear > 2015) {
                baseQuote += 25;
            }

            if (carMake.Equals("Porsche")) {
                baseQuote += 25;
                if (carModel.Equals("911 Carrera")) {
                    baseQuote += 25;
                }
            }

            baseQuote += tickets * 10;

            if (dui) baseQuote += (baseQuote / 4);

            if (full) baseQuote += (baseQuote / 2);

            return baseQuote;
        }
    }
}
