using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApp.Controllers
{
    public class BankFormController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: BankForm
        
        public ActionResult Submit()
        {            
            return View();
        }

        public ActionResult AfterLogin(Bank bank)
        {
            using (BankDataEntities bde = new BankDataEntities())
            {
                bde.Banks.Add(bank);
                bde.SaveChanges();
            }
                return View(bank);
        }

    }
}