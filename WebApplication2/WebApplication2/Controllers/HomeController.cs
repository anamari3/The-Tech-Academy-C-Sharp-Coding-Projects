using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello"; //Logging visits to site
            //System.IO.File.WriteAllText(@"C:\Users\Student\samplelog.txt", text);

            //Random rnd = new Random(10); //return something else
            //int num = rnd.Next();

            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //return Content("Hello"); //return content. if left blank ("") it returns nothing.

            //return RedirectToAction("Contact"); //different than returning a different View which returns cshtml file, doesnt change url

            //List<string> names = new List<string> //example of a mofel
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett",
            //};
            //return View(names);

            //int number = 5;

            User user = new User();
            user.id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.age = 32;
            return View(user); //passing user as our model to our view
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new Exception("Invalid page"); //can throw an error

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            //ViewBag.Message = "Your contact page.";
            ViewBag.Message = id;

            return View();
        }
    }
}