using BabySit.Database_Access;
using BabySit.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
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

        [HttpPost]
        public IActionResult Verify(VerifyCode verify, User user)
        {
            var sessionUser = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));

            using (ProjectPRNContext db = new ProjectPRNContext())
            {
                if (HttpContext.Session.GetInt32("SessionCode") == verify.CodeInput)
                {
                    db.Users.Add(sessionUser);
                    db.SaveChanges();
                    return View("Login");
                }
                else
                {
                    ViewBag.IncorrectCodeMessage = "Bạn đã nhập sai mã!";
                    return View("Verify");
                }
            }
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login(RememberMe user)
        {
            var userDetails = db.Users.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();

            if (userDetails == null)
            {
                ViewBag.Message = "Tài khoản không tồn tại hoặc sai mật khẩu";
            }
            else
            {
                
                if (userDetails != null && userDetails.Role == 3)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, "3"),
                    };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.Now.AddMinutes(10),
                    };

                    await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                    return RedirectToAction("AdminDashboard", "Home");
                }
                else
                {
                    var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Email, user.Email),
                            new Claim(ClaimTypes.Role, "1"),
                            new Claim(ClaimTypes.Role, "2"),
                        };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.Now.AddMinutes(10),
                    };

                    await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                    return RedirectToAction("HomePage", "Home");
                }
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            UserRegister userRegister = new UserRegister();
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user, UserRegister userRegister)
        {
            user.RegisterDate = DateTime.Now;
            Random random = new Random();
            VerifyCode verifyCode = new VerifyCode();
            verifyCode.CodeSend = random.Next(1000, 9999);
            verifyCode.Email = user.Email;
            SendEmail sendEmail = new SendEmail();
            if (ModelState.IsValid)
            {
                using (ProjectPRNContext db = new ProjectPRNContext())
                {
                    if (user.Password != userRegister.confirmPassword)
                    {
                        ViewBag.PasswordDoNotMatchMessage = "Mật khẩu nhập lại không trùng với mật khẩu đã nhập!";
                        return View("Register");
                    }
                    else
                    {
                        var check = db.Users.Where(x => x.Email == user.Email).FirstOrDefault();
                        if (check == null)
                        {
                            string subject = "Xin gửi bạn mã xác nhận của BabySit";
                            string content = "Mã xác nhận của bạn là: ";
                            bool checkSendMail = sendEmail.SendEmailVerify(user.Email, subject, content, verifyCode.CodeSend);
                            if (checkSendMail == true)
                            {
                                //gửi mail xong thì lưu vào session
                                HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(user));
                                HttpContext.Session.SetInt32("SessionCode", verifyCode.CodeSend);
                                ModelState.Clear();
                                return View("Verify");
                            }
                            else
                            {
                                ViewBag.MessageErrorSendEmail = "Quá trình gửi có thể đã phát sinh lỗi!";
                                return View("Register");
                            }
                        }
                        else
                        {
                            ViewBag.EmailExistMessage = "Email này đã được dùng, mời bạn chọn email khác!";
                            return View("Register");
                        }
                    }
                }
            }
            else
            {
                ViewBag.InvalidMessage = "Một số trường không hợp lệ, mời bạn nhập lại!";
                return View("Register");
            }
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
            var model = new LocationAndUser();
            model.users = db.Users.Where(x => x.Role == 2).ToList();
            model.locations = db.Locations.ToList();
            return View(model);
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
