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

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }


        // POST: Insuree/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                insuree.Quote = calculateQuote(insuree.DateOfBirth, insuree.CarYear, insuree.CarMake, 
                    insuree.CarModel, insuree.DUI, insuree.SpeedingTickets, insuree.CoverageType);
                //call method to get quote (calculate) and assign quote before saving it
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
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
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

        ///EVERTHING HERE I CREATED
        public decimal calculateQuote (System.DateTime DateOfBirth, int CarYear, string CarMake, string CarModel,
                        bool DUI, int SpeedingTickets, bool CoverageType)
        {
            int quote = 50;
            var today = DateTime.Today;
            var age = (today.Year - DateOfBirth.Year);
            age = Convert.ToInt16(age);

            if (age < 25 && age > 18 || age > 100)
            {
                quote = quote + 25;
            }
            else if (age < 18)
            {
                quote = quote + 100;
            }

            if (CarYear < 2000  || CarYear > 2015)
		    {
			    quote = quote + 25;
		    }
		
		    if (CarMake == "porche")
		    {
			    quote = quote + 25;
		    }

            if (CarMake == "porche" && CarModel == "911 carrera")
            {
                quote = quote + 25;
            }

            if (SpeedingTickets > 0)
            {
                quote = quote + (10 * SpeedingTickets);
            }

            if (DUI == true)
            {
                decimal twentyFivePercent = 1.25m;
                decimal decQuote = Convert.ToDecimal(quote);
                quote = Convert.ToInt32(decQuote * twentyFivePercent);
            }
                if (CoverageType == true)
                {
                    decimal fiftyPercent = 1.5m;
                    decimal decQuote = Convert.ToDecimal(quote);
                    quote = Convert.ToInt32(decQuote * fiftyPercent);
                }
                decimal calculatedQuote = Convert.ToDecimal(quote);

            return calculatedQuote;
        }











        }
}
