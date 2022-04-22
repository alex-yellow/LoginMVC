using LoginMVC.Models;
using LoginMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginMVC.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Account account)
        {
            if(account.Username.Equals("abc") && account.Password.Equals("123"))
            {
                Session["username"] = account.Username;
                return View("Welcome");
            }
            else
            {
                ViewBag.Error = "Аккаунт не найден";
                return View("Index");
            }
        }
        public ActionResult Logout()
        {
            Session.Remove("username");
            return RedirectToAction("Index");
        }
    }
}