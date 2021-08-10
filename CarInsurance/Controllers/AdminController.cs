using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees.ToList();
                var insureeVms = new List<InsureeVm>();
                
                foreach (var insuree in insurees)
                {
                    var insureeVm = new InsureeVm();
                    insureeVm.Quote = insuree.Quote;
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVms.Add(insureeVm);
                }
                return View(insureeVms);
            }
            
        }
    }
}