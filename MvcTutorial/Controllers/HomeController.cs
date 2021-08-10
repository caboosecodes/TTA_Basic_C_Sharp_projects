using MvcTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\Ricar\Desktop\twentyoneIO\MvcTutorial\log.txt", text);

            //Random rnd = new Random(10);
            //int num = rnd.Next();
            // viewbag is like a dictionary, you can put in any kind of datatype
            // you can return another view as long as its in the same controller
            //if (num > 2000)
            //{
            //    return View("About");
            //}

            //return Content("hello");

            // returns the contact page BUT you actually send it to the Contact() method in the controller
            //return RedirectToAction("Contact");
            // this returns the contact page as well but does not hit Contact method so if there's logic in that controller it will not be executed
            //return View("Contact");

            //List<string> names = new List<string>()
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};
            //// pass in the list to the view

            User user = new User();
            user.Id = 1;
            user.FirstName = "Ricardo";
            user.LastName = "Lopez";
            user.Age = 32;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid Page");

            return View();
        }
        // Action result is a data type
        // very specific to MVC
        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;
            // view() is a method from Controller
            // View() method finds the right cshtml file
            return View();
        }
    }
}