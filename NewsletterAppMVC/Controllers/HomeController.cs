using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        // need a connection string
        //private readonly string connectionString = @"Data Source=LAPTOP-1U27SKAF\SQLEXPRESS;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }

        // When ever you are doing a post method you are supposed to put this tag above it
        [HttpPost]
        // MVC knows what information to map the parameters in the method
        // ActionResult has to turn a datatype of ActionResult, which is a very broad data type
        public ActionResult SignUp(string firstName, string lastName, string emailAddress) 
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                // ~ is for a relative path
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using(NewsletterEntities db = new NewsletterEntities())
                {
                    // map the properties the object to the parameters coming in
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.SignUps.Add(signup);
                    // nothing is saved until SaveChanges method is executed
                    db.SaveChanges();

                }

                //// save the information to a database with ADO

                //// helps prevent sql injection attacks; you never want to pass raw user input as your sql queries, always use parameters
                //string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                //                        (@FirstName, @LastName, @EmailAddress)";
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);
                //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                //    // assign the parameters their values
                //    command.Parameters["@FirstName"].Value = firstName;
                //    command.Parameters["@LastName"].Value = lastName;
                //    command.Parameters["@EmailAddress"].Value = emailAddress;

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();

                //}
                return View("Success");
            }
        }
    }
}