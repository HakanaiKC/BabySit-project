using BabySit.Database_Access;
using BabySit.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
