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
    }
}
