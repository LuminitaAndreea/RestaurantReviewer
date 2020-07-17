using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using RestaurantReviewer.Models;
using Microsoft.AspNetCore.Session;

namespace RestaurantReviewer.Controllers
{
    public class UserController : Controller
    {
        private readonly Context _context;
        public  UserController( Context context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            int count = _context.Users.Count(a => a.Username.Equals(username) && a.Password.Equals(password));
            if (count > 0)
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Login");

            }

        }

        [HttpGet]
        public ActionResult Register()
        {
            return View("Register");
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Login", "User");
        }
        public ActionResult Profile(string username)
        {
            username = HttpContext.Session.GetString("username");
            User user = _context.Users.FirstOrDefault(m => m.Username == username);
            if (username == null)
            {
                return RedirectToAction("Login", "User");
            }
            else
            {
                if (user == null)
                {
                    return NotFound();
                }
                else
                {
                    return View(user);
                }
            }
            
        }
    }
}