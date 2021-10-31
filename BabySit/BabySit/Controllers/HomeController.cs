﻿using BabySit.Database_Acess;
using BabySit.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BabySit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        ProjectPRNContext db = new ProjectPRNContext();
        public IActionResult Index()
        {
            var userDetails = db.Users.Where(x => x.Role == 2).ToList();
            ViewData.Model = userDetails;
            return View();
        }

        public IActionResult Verify()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(RememberMe user)
        {
            var userDetails = db.Users.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();

            if (userDetails == null)
            {
                ViewBag.Message = "Tài khoản không tồn tại hoặc sai mật khẩu";
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult AdminContract()
        {
            return View();
        }
        public IActionResult AdminDashboard()
        {
            return View();
        }
        public IActionResult AdminUserManagement()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Babysitter(int id)
        {
            var model = new Babysitter();
            model.users = db.Users.ToList();
            model.skills = db.Skills.ToList();
            model.locations = db.Locations.ToList();
            model.userskills = db.UserSkills.ToList();

            var babyDetails = (from baby in model.users
                               join localtion in model.locations
                               on baby.ProvinceId equals localtion.ProvinceId
                               where baby.UserId == id
                               select new User()
                               {
                                   Name = baby.Name,
                                   UserId = baby.UserId,
                                   Avatar = baby.Avatar,
                                   Gender = baby.Gender,
                                   BirthOfDate = baby.BirthOfDate,
                                   Phone = baby.Phone,
                                   Province = baby.Province,
                                   Description = baby.Description,
                                   YearsOfExperience = baby.YearsOfExperience,
                                   SalaryPerHour = baby.SalaryPerHour
                               });

            var babySkill = (from baby in model.users
                             join userskill in model.userskills on baby.UserId equals userskill.UserId
                             join skills in model.skills on userskill.SkillId equals skills.SkillId
                             where baby.UserId == id
                             select new Skill { SkillName = skills.SkillName, SkillId = skills.SkillId });

            Babysitter babysitter = new Babysitter()
            {
                users = babyDetails,
                skills = babySkill
            };
            return View(babysitter);
        }

        public IActionResult CreateContract()
        {
            return View();
        }

        public IActionResult EditProfile()
        {
            return View();
        }

        public IActionResult HomePage()
        {

            return View();
        }
        public IActionResult ForgotPass()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
