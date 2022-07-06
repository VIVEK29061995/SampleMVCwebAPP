using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace SampleMVCwebAPP.Controllers
{
    public class PersonController : Controller
    {

        //GET: Person
        [HttpGet]
        public IActionResult PersonalDetails()
        {
            List<string> Options = new List<string>();
            Options.Add("Choose an Option");
            Options.Add("Yes");
            Options.Add("No");
         ViewData["Options"] = new SelectList(Options);// <--is for single //And multiple selection Use "MultiSelectList"


            return View();
        }

        [HttpPost] //attribute
        public ActionResult PersonalDetails (IFormCollection fc,ICollection<string> hobbies)
        {
            ViewBag.firstname = fc["firstname"];
            ViewBag.lastname = fc["lastname"];
            ViewBag.phone = fc["phone"];
            ViewBag.gender = fc["Gender"];
            ViewBag.hobbies = hobbies;
            ViewBag.options = fc["Options"];
            return View("Details");




        }
    }
}
