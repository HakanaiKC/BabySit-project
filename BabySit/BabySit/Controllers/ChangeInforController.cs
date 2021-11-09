using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Controllers
{
    public class ChangeInforController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ChangeInformation(string fullname, bool gender, DateTime txtDate, string address, string textarea)
        {
            ViewBag.fullname = fullname;
            ViewBag.gender = gender;
            ViewBag.txtDate = txtDate;
            ViewBag.address = address;
            ViewBag.textarea = textarea;
            //RedirectToAction("Index");
            return View("Index");
        }
    }
}
