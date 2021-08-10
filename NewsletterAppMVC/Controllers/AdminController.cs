using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // Our Index method HERE is going to be the same as the admin method we had in HomeController

        // GET: Admin
        public ActionResult Index()
        {
            // Replacing with Entity Framework syntax
            //best practice to wrap instantiated entity objects in using statements so that the database connection is closed when we are done
            using (NewsletterEntities db = new NewsletterEntities())
            {
                // db has a property, SignUps, which represents all the records in the database
                // llambda syntax
                // Where().ToList()
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();

                // Linq syntax
                // linq is used to sort lists
                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();
                var signupVms = new List<SignupVm>();
                // map your database onjects to a View Model
                foreach (var signup in signups)
                {
                    // mapping properties
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }

                // pass the List to the View
                return View(signupVms);
            }

            //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber FROM SignUps";
            //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);

            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        var signup = new NewsletterSignUp();
            //        // things that come from databases are of a different data types to you need to convert
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.LastName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["EmailAddress"].ToString();
            //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
            //        // adds the signup to the List
            //        signups.Add(signup);

            //    }
            //}

        }

        public ActionResult Unsubscribe(int Id)
        {
            // establishes connection to the database
            using (NewsletterEntities db = new NewsletterEntities())
            {
                // db.Signups.Find() is a method that finds the primary key
                var signup = db.SignUps.Find(Id);
                // changing the removed and assigning it DateTime
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }


    }
}