using BabySit.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [HttpPost]
        public IActionResult ChangePassword(string newpassword, string renewpassword, string oldpassword)
        {
            int id = (JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionID"))).UserId;
            var userDetails = db.Users.Where(x => x.UserId == id).FirstOrDefault();
            //ViewBag.dbpass= userDetails.Password;
            //ViewBag.oldpass = oldpassword;
            //ViewBag.newpass = newpassword;
            //ViewBag.renewpass = renewpassword;

            if (oldpassword.Equals(userDetails.Password))
            {
                if (renewpassword.Equals(newpassword))
                {
                    userDetails.Password = newpassword;
                    db.Update(userDetails);
                    db.SaveChanges();
                    TempData["messPass"] = "Success";
                }
                else
                {
                    TempData["messPass"] = "Re-new Password không khớp New Password";
                }
            }
            else
            {
                TempData["messPass"] = "Sai mật khẩu rồi";
            }

            //return View("Index");
            return RedirectToAction("EditProfile", "Home");
        }

        [HttpPost]
        public IActionResult ChangeSkill(string skillinlife)
        {

            int id = (JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionID"))).UserId;
            //var userSkill = db.UserSkills.Where(c=> c.UserId == id).ToList();
            string[] listSkill = skillinlife.Split(" ");
            int delete = db.RemoveUserSkills(id);
            int a = listSkill.Length;
            for (int i = 0; i < a - 1; i++)
            {
                int b = db.AddUserSkills(id, listSkill[i]);
            }
            return RedirectToAction("EditProfile", "Home");
        }
    }
}
