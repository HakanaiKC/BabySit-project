using BabySit.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Controllers
{
    public class ChangeInforController : Controller
    {
        ProjectPRNContext db = new ProjectPRNContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ChangeInformation(string fullname, bool gender, DateTime txtDate, int address, string description, float salary, int experienceYear)
        {
            int id = (JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionID"))).UserId;

            var userDetails = db.Users.Where(x => x.UserId == id).FirstOrDefault();
            userDetails.BirthOfDate = txtDate;
            userDetails.Gender = gender;
            userDetails.Name = fullname;
            userDetails.ProvinceId = address;
            userDetails.Description = description;
            userDetails.SalaryPerHour = salary;
            userDetails.YearsOfExperience = experienceYear;
            db.Update(userDetails);
            db.SaveChanges();
            return RedirectToAction("EditProfile", "Home");
        }
        public IActionResult ChangePassword(string newpassword, string renewpassword, string oldpassword)
        {
            ViewBag.oldpass = oldpassword;
            ViewBag.newpass = newpassword;
            ViewBag.renewpass = renewpassword;
            return View("Index");
            //return RedirectToAction("EditProfile", "Home");
        }
    }
}
