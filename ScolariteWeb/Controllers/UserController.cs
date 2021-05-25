using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scolarite.Domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScolariteWeb.Controllers
{
   
    public class UserController : Controller
    {
        ModelContext md = null;
        public UserController(ModelContext model)
        {
            md = model;

        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RegisterNewUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterNewUser(Appuser u)
        {
            try
            {
                md.Appuser.Add(u);
                md.SaveChanges();
                ViewBag.Message = "User" + u.Loginname + "Registered successfully.";
            }
            catch
            {
                ViewBag.Message = "Unable to save new user, please try again";
            }

            return View();
        }



        [HttpGet]
        public IActionResult Login()
        {
            if(Request.Cookies["LastLoggedInTime"]!=null)

            ViewBag.LTLD = Request.Cookies["LastLoggedInTime"].ToString();
            return View();
        }


        public IActionResult Login(Appuser u)
        {
           Appuser LoggedInUser= md.Appuser.Where(x => x.Loginname == u.Loginname && x.Password == u.Password).FirstOrDefault();
            if (LoggedInUser == null)
            {
                ViewBag.Message = "Wrong Login PAssword";
                return View();
            }
            //save user information  in session
            HttpContext.Session.SetString("Loginname", LoggedInUser.Loginname);

            Response.Cookies.Append("LastLoggedInTime", DateTime.Now.ToString()); 
            
            return RedirectToAction("Dashboard");
        }

        public IActionResult Dashboard()
        {
            if(string.IsNullOrEmpty( HttpContext.Session.GetString("Loginname") ))
            {
                return RedirectToAction("Login");
            }
            ViewBag.Loginname = HttpContext.Session.GetString("Loginname");
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

    }
   
}
