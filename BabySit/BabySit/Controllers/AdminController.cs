using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles = "3")]
        public IActionResult AdminContract()
        {
            return View();
        }

        [Authorize(Roles = "3")]
        public IActionResult AdminDashboard()
        {
            return View();
        }

        [Authorize(Roles = "3")]
        public IActionResult AdminUserManagement()
        {
            return View();
        }
    }
}
