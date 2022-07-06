using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace SampleMVCwebAPP.Controllers
{
    public class LoginController1 : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        public IActionResult NewUser()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}
