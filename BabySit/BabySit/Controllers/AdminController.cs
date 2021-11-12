using BabySit.Database_Access;
using BabySit.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Controllers
{
    public class AdminController : Controller
    {
        ProjectPRNContext db = new ProjectPRNContext();
        public IActionResult AdminContract()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AdminConfirmPremium()
        {
            if (HttpContext.Session.GetString("SessionID") != null)
            {
                var role = (JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionID"))).Role;
                if (role > 0)
                {
                    ViewBag.role = role;
                }
                else
                {
                    ViewBag.role = 0;
                }
            }
            var model = new Babysitter();
            model.payment = db.Payments.ToList();
            model.users = db.Users.ToList();

            return View(model);
        }
        [HttpPost]
        public IActionResult AdminConfirmPremium(Babysitter baby)
        {
            if (HttpContext.Session.GetString("SessionID") != null)
            {
                var role = (JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionID"))).Role;
                if (role > 0)
                {
                    ViewBag.role = role;
                }
            }
            var model = new Babysitter();
            model.payment = db.Payments.ToList();
            model.users = db.Users.ToList();
            int paymentId = Int32.Parse(Request.Form["paymentId"]);
            int userId = Int32.Parse(Request.Form["userId"]);
            var dataPayment = db.Payments.FirstOrDefault(x => x.PaymentId == paymentId);
            if (dataPayment != null)
            {
                dataPayment.Status = true;
            }

            var dataUser = db.Users.FirstOrDefault(x => x.UserId == userId);
            if (dataUser != null)
            {
                dataUser.Status = 1;
            }
            db.SaveChanges();
            return View(model);
        }

        public IActionResult AdminUserManagement()
        {
            return View();
        }
    }
}
