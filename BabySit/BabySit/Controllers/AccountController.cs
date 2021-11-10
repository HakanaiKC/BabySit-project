using BabySit.Database_Access;
using BabySit.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BabySit.Controllers
{
    public class AccountController : Controller
    {

        ProjectPRNContext db = new ProjectPRNContext();

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

                    ViewBag.RegisterSuccessfully = "Đăng ký thành công, mời bạn đăng nhập!";
                    return View("Login");
                }
                else
                {
                    ViewBag.IncorrectCodeMessage = "Bạn đã nhập sai mã!";
                    return View("Verify");
                }
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(User user, bool remember)
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
                    HttpContext.Session.SetString("SessionAdmin", JsonConvert.SerializeObject(userDetails));
                    return RedirectToAction("AdminDashboard", "Admin");
                }
                else if (userDetails != null && (userDetails.Role == 1 || userDetails.Role == 2))
                {
                    HttpContext.Session.SetString("SessionID", JsonConvert.SerializeObject(userDetails));
                    //if (TempData["path"] != null)
                    //{
                    //    string url = (string)TempData["path"];
                    //    return Redirect(url);                       
                    //}
                    //else
                    //{
                        return RedirectToAction("HomePage", "Home");
                    //}
                }
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("SessionID");
            HttpContext.Session.Remove("SessionAdmin");
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


        [HttpGet]
        public IActionResult ForgotPass()
        {
            return View("ForgotPass");
        }

        [HttpPost]
        public IActionResult ForgotPass(User user)
        {
            Random random = new Random();
            VerifyCode verifyCode = new VerifyCode();
            verifyCode.CodeSend = random.Next(10000000, 99999999);
            using (ProjectPRNContext db = new ProjectPRNContext())
            {
                if (db.Users.Where(x => x.Email == user.Email).FirstOrDefault() != null)
                { //check xem email có trong dtb không
                    SendEmail sendEmail = new SendEmail();
                    string subject = "Xin gửi bạn mật khẩu mới của tài khoản Baybysit";
                    string content = "Mật khẩu mới của bạn là: ";
                    bool checkSendMail = sendEmail.SendEmailVerify(user.Email, subject, content, verifyCode.CodeSend);
                    if (checkSendMail == true)
                    {
                        int userId = db.Users.FirstOrDefault(t => t.Email.Contains(user.Email)).UserId;//lấy userId từ user trong dtb có email = email đã nhập 
                        var FindUserByID = db.Users.Find(userId);
                        FindUserByID.Password = verifyCode.CodeSend.ToString();
                        db.SaveChanges();
                        ViewBag.MessageChangePasswordSuccess = "Đổi mật khẩu thành công, mời bạn check email!";
                        return View("Login");
                    }
                    else
                    {
                        ViewBag.MessageErrorSendEmail = "Quá trình gửi có thể đã phát sinh lỗi!";
                        return View("ForgotPass");
                    }
                }
                else
                {
                    ViewBag.InvalidEmailMessage = "Email này chưa được đăng ký!";
                    return View("ForgotPass");
                }
            }
        }

    }
}
