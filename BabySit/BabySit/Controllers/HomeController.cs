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


        [HttpGet]
        public ActionResult History()
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
            var userID = (JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionID"))).UserId;
            var history = db.Payments.Where(h => h.UserId == userID).OrderBy(h => h.Status).ToList();
            return View("History", history);


        }
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
        public IActionResult CreateContract(int id)
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

        [HttpGet]
        public IActionResult HomePage()
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
            model.users = db.Users.Where(x => x.Role == 2 && x.Gender != null && x.SalaryPerHour != null
            && x.ProvinceId != null).ToList();
            model.skills = db.Skills.ToList();
            model.locations = db.Locations.ToList();
            model.userskills = db.UserSkills.ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult HomePage(Babysitter babysitter)
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
            try
            {
                var model = new Babysitter();
                model.users = db.Users.Where(x => x.Role == 2 && x.Gender != null && x.SalaryPerHour != null
               && x.ProvinceId != null).ToList();
                model.locations = db.Locations.ToList();
                model.shift = db.Shifts.ToList();

                int Location = Int32.Parse(Request.Form["selectKhuVuc"]);
                int Year = Int32.Parse(Request.Form["selectKinhNghiem"]);
                String Time = Request.Form["selectTime"];
                int Salary = Int32.Parse(Request.Form["selectMucLuong"]);

                bool night = true, morning = true, afternoon = true;

                if (!Time.Contains("1"))
                {
                    morning = false;
                }
                if (!Time.Contains("2"))
                {
                    afternoon = false;
                }
                if (!Time.Contains("3"))
                {
                    night = false;
                }

                var babyDetails = (from baby in model.users
                                   join localtion in model.locations
                                   on baby.ProvinceId equals localtion.ProvinceId
                                   join shift in model.shift on baby.UserId equals shift.BabySitterId
                                   where baby.ProvinceId == Location
                                   && Year == baby.YearsOfExperience && baby.SalaryPerHour <= Salary
                                   && shift.Morning == morning && shift.Afternoon == afternoon && shift.Night == night
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

                babysitter = new Babysitter()
                {
                    users = babyDetails
                };
                ViewBag.test = Time;

                return View(babysitter);
            }
            catch
            {
                var model = new Babysitter();
                model.users = db.Users.Where(x => x.Role == 2 && x.Gender != null && x.SalaryPerHour != null
                && x.ProvinceId != null).ToList();
                model.skills = db.Skills.ToList();
                model.locations = db.Locations.ToList();
                model.userskills = db.UserSkills.ToList();
                return View(model);
            }
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
            var model = new Babysitter();
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

                Babysitter babysitter = new Babysitter()
                {
                    users = babyDetails,
                    skills = babySkill
                };
                ViewBag.search = searching;
                return View("HomePage", babysitter);
            }

            return View("HomePage", model);

        }

        [HttpPost]
        public IActionResult Payment(Babysitter babysitter)
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
            int userId = (JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionID"))).UserId;
            String PhoneNumber = Request.Form["PhoneNumber"];
            String TradingCode = Request.Form["TradingCode"];

            using (ProjectPRNContext db = new ProjectPRNContext())
            {
                Payment payment = new Payment();
                payment.Phone = PhoneNumber;
                payment.TradingCode = TradingCode;
                payment.Status = false;
                payment.DateOfPayment = DateTime.Now;
                payment.UserId = userId;
                db.Payments.Add(payment);
                db.SaveChanges();

            }
            ViewBag.SendRequestSuccessfully = "Đã gửi yêu cầu đến admin thành công!";
            return View();
        }

        [HttpGet]
        public IActionResult Payment()
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
        public IActionResult Feedback(int babysitterId, string feedback, int myField)
        {
            int parentId = (JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionID"))).UserId;
            var feedbacks = db.FeedBacks.ToList();
            var feedbackindb = (from c in feedbacks
                                where (c.BabySitterId == babysitterId && c.ParentId == parentId)
                                select c).FirstOrDefault();
            FeedBack feedBack = new FeedBack();
            feedBack.BabySitterId = babysitterId;
            feedBack.ParentId = parentId;
            feedBack.Rate = myField;
            feedBack.Comment = feedback;
            feedBack.DateComment = DateTime.Now;
            if (feedbackindb == null)
            {
                // khong ton tai thi insert;
                db.FeedBacks.Add(feedBack);
            }
            else
            {
                feedbackindb.Rate = myField;
                feedbackindb.Comment = feedback;
                feedbackindb.DateComment = DateTime.Now;
                db.FeedBacks.Update(feedbackindb);
                //ton tai thi update
            }
            db.SaveChanges();
            //ViewBag.Feedbackid = feedbackindb.FeedBackId;
            //ViewBag.baby = babysitterId;
            //ViewBag.feedback = feedback;
            //ViewBag.rate = myField;
            //ViewBag.date = DateTime.Now;
            //return View("Nhap");
            return Redirect("Babysitter/" + babysitterId);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
