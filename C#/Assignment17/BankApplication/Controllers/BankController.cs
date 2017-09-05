using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApplication.Controllers
{
    public class BankController : Controller
    {
        // GET: Bank
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoginHome(UserAccountDetail uad)
        {
            using (BankDataEntities bde = new BankDataEntities())
            {
                bde.UserAccountDetails.Add(uad);
                bde.SaveChanges();
            }
                return View(uad);
        }
        public ActionResult Register()
        {
            return View();
        }

        
        public ActionResult AfterLogin(UserAccountDetail uad)
        {
            return View(uad);
        }

        public ActionResult Login(UserAccountDetail uad)
        {
            var u =false;
            using (BankDataEntities bde = new BankDataEntities())
            {
                foreach (var item in bde.UserAccountDetails.Where((i)=>i.Username.Equals(uad.Username) && i.Password.Equals(uad.Password)))
                {
                    u = true;
                }
            }

            if (u)
                return View("AfterLogin",uad);
            else
                return View();
        }
    }
}