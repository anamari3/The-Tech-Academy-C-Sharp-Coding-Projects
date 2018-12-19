using InsuranceQuotes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceQuotes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsuranceQuote(string firstName, string lastName, string emailAddress, DateTime birthDate, int carYear, string carMake,
            string carModel, bool dui, int speedingTicket, bool fullCoverage, decimal quote)
        {
            
            if (string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (QuotesEntities db = new QuotesEntities())
                {
                    quote = 50m;

                    var request = new InsuranceQuote();
                    request.FirstName = firstName;
                    request.LastName = lastName;
                    request.EmailAddress = emailAddress;
                    request.DateOfBirth = birthDate;

                    int age = Convert.ToInt16(DateTime.Now - birthDate);
                    if (age >= 18 && age<=25 || age>100)
                    {
                        quote = quote + 25m;
                    }
                    if (age > 18)
                    {
                        quote = quote + 100m;
                    }

                    request.CarYear = carYear;
                    request.CarMake = carMake;
                    request.CarModel = carModel;
                    request.DUI = dui;
                    request.SpeedingTicket = speedingTicket;
                    request.FullCoverage = fullCoverage;

                    //needs to create formulas for quote here 

                    request.Quote = quote;

                    db.InsuranceQuotes.Add(request);
                    db.SaveChanges();
                }
            }
            return View("Quote");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}