using BabySit.Database_Access;
using BabySit.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
            var userDetails = db.Users.Where(x => x.Role == 2).ToList();
            ViewData.Model = userDetails;
            return View();
        }

        public IActionResult ContactUs()
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
            return View();
        }

        [HttpGet]
        public IActionResult Babysitter(int id)
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
            model.users = db.Users.Where(x => x.Role == 2 && x.Gender != null && x.SalaryPerHour != null && x.ProvinceId != null).ToList();
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
            ViewBag.Shift = db.Shifts.Where(c => c.BabySitterId == id).ToList();
            return View(babysitter);
        }

        [HttpGet]
        public IActionResult Chat(int id)
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
                int userid = (JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionID"))).UserId;
                ViewBag.id = userid;
                return View();
            }
            else
            {
                Uri myUri = new Uri($"http://localhost:39977/Home/CreateContract/{id}");
                string pathpart = myUri.PathAndQuery;
                TempData["path"] = pathpart;
                return RedirectToAction("Login", "Account");
            }
        }

        public IActionResult EditProfile()
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
            int id = (JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionID"))).UserId;
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

            var CheckSkills = new List<CheckSkill>();
            foreach (var item in model.skills)
            {
                bool check = false;
                foreach (var item2 in babySkill)
                {
                    if (item.SkillId == item2.SkillId)
                    {
                        check = true;
                        break;
                    }
                }
                CheckSkills.Add(new CheckSkill(item.SkillId, item.SkillName, check));
            }

            ViewBag.test = id;
            ViewBag.Skill = CheckSkills.Where(x => x.SkillId < 6);
            ViewBag.CheckSkills = CheckSkills.Where(x => x.SkillId >= 6);
            ViewBag.locations = db.Locations.ToList();
            ViewBag.Shift = db.Shifts.Where(c => c.BabySitterId == id).ToList();
            return View(babysitter);
        }

        public IActionResult HomePage()
        {
            var model = new Babysitter();
            model.users = db.Users.Where(x => x.Role == 2 && x.Gender != null && x.SalaryPerHour != null && x.ProvinceId != null).ToList();
            model.skills = db.Skills.ToList();
            model.locations = db.Locations.ToList();

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
            return View(model);
        }

        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        [HttpGet]
        public ActionResult Search(string searching)
        {
            var model = new Search();
            model.users = db.Users.Where(x => x.Role == 2 && x.Gender != null && x.SalaryPerHour != null && x.ProvinceId != null).ToList();
            model.skills = db.Skills.ToList();
            model.locations = db.Locations.ToList();
            model.userskills = db.UserSkills.ToList();

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

            if (!string.IsNullOrEmpty(searching))
            {
                var babyDetails = (from baby in model.users
                                   join localtion in model.locations
                                 on baby.ProvinceId equals localtion.ProvinceId
                                   where ((convertToUnSign3(baby.Name.ToLower()).Contains(convertToUnSign3(searching.ToLower()))) || baby.Name.ToLower().Contains(searching.ToLower()))
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
                                 where (convertToUnSign3(baby.Name.ToLower()).Contains(convertToUnSign3(searching.ToLower())))
                                 select new Skill { SkillName = skills.SkillName, SkillId = skills.SkillId });

                Search babysitter = new Search()
                {
                    users = babyDetails,
                    skills = babySkill
                };
                ViewBag.search = searching;
                return View(babysitter);

            }

            return View(model);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
