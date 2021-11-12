using BabySit.Database_Access;
using BabySit.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Controllers
{
    public class ChangeInforController : Controller
    {
        ProjectPRNContext db = new ProjectPRNContext();

        private readonly IWebHostEnvironment webHost;
        private readonly ILogger<HomeController> _logger;
        public ChangeInforController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            webHost = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ChangeInformation(string fullname, bool gender, DateTime txtDate, int address, string description, float salary, int experienceYear, string skillinlife, string shift)
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
            if (userDetails.Role==2)
            {
                string[] listSkill = skillinlife.Split(" ");
                int delete = db.RemoveUserSkills(id);
                int a = listSkill.Length;
                for (int i = 0; i < a - 1; i++)
                {
                    int b = db.AddUserSkills(id, listSkill[i]);
                }
                for (int i = 0; i < 7; i++)
                {
                    db.UpdateShift(id, i + 2, shift[i].ToString(), shift[i + 7].ToString(), shift[i + 14].ToString());
                }
                ViewBag.skillinlife = skillinlife;
                string st = shift[0].ToString();
                ViewBag.skillTr = st;
            }
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
        public IActionResult ImportImage(Babysitter baby)
        {
            int id = (JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionID"))).UserId;
            string fileName = UploadFile(baby);
            var user = db.Users.Single(x=>x.UserId==id);
            user.Avatar = fileName;
            db.SaveChanges();
            return RedirectToAction("EditProfile", "Home");
        }

        private string UploadFile(Babysitter baby)
        {
            string filename = null;
            if (baby.Avatar != null)
            {
                string uploadDir = Path.Combine(webHost.WebRootPath, "images");
                filename = Guid.NewGuid().ToString()+"-"+baby.Avatar.FileName;
                string filepath = Path.Combine(uploadDir, filename);
                using (var filestream = new FileStream(filepath,FileMode.Create))
                {
                    baby.Avatar.CopyTo(filestream);
                }
            }
            return filename;
        }
    }
}
