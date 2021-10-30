using BabySit.Models;
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

        public IActionResult Index(BabySit.Models.User user)
        {
            using (ProjectPRNContext db = new ProjectPRNContext())
            {
                var userDetails = db.Users.Where(x => x.Role == 2).ToList();
                ViewData.Model = userDetails;
                return View();
            }
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
        public IActionResult Login(BabySit.Models.User user)
        {
            using (ProjectPRNContext db = new ProjectPRNContext())
            {
                var userDetails = db.Users.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
                if (userDetails == null)
                {
                    ViewBag.Message = "Tài khoản không tồn tại hoặc sai mật khẩu";
                    return View();
                }
                else
                {
                    return RedirectToAction("HomePage");
                }
            }
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
            using (ProjectPRNContext db = new ProjectPRNContext())
            {
                List<User> users = db.Users.ToList();
                List<Location> local = db.Locations.ToList();
                //var babysitDetails = db.Users.Where(x => x.UserId == id).FirstOrDefault();
                var query = from baby in users
                            join localtion in local 
                            on baby.ProvinceId equals localtion.ProvinceId
                            where baby.UserId == id
                            select new
                            {
                                ten = baby.Name,
                                babyId = baby.UserId,
                                avatar = baby.Avatar,
                                gender = baby.Gender,
                                bod = baby.BirthOfDate,
                                phone = baby.Phone,
                                provine = baby.Province,
                                descirption = baby.Description,
                                year = baby.YearsOfExperience,
                                salary = baby.SalaryPerHour
                            };
                ViewData.Model = query;
                return View(query);
            }
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
