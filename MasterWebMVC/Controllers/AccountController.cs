using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MasterWebMVC.Models;

namespace MasterWebMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
			using (OurDBContext db = new OurDBContext())
			{
				return View(db.userAccount.ToList());
			}
        }

		public ActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Register(UserAccount account)
		{
			if (ModelState.IsValid)
			{
				using (OurDBContext db = new OurDBContext())
				{
					db.userAccount.Add(account);
					db.SaveChanges();
				}

				ModelState.Clear();
				ViewBag.Message = account.FirstName + " " + account.LastName + " registrado correctamente";
			}
			return View();
		}

		//Login
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(UserAccount user)
		{
			using (OurDBContext db = new OurDBContext())
			{
				var usr = db.userAccount.Single(u => u.Username == user.Username && u.Password == user.Password);
				if (usr != null)
				{
					Session["UserID"] = usr.UserID.ToString();
					Session["Username"] = usr.Username.ToString();
					return RedirectToAction("LoggedIn");
				}

				else
				{
					ModelState.AddModelError("", "Nombre de usuario o contraseña incorrecto.");
				}
			}
			return View();
		}

		public ActionResult LoggedIn()
		{
			if (Session["UserID"] != null)
			{
				return View();
			}

			else
			{
				return RedirectToAction("Login");
			}
		}
    }
}