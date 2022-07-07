using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SampleMVCwebAPP.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult EmployeeDetails()
        {

            List<string> Options = new();
            Options.Add("Choose an Option");
            Options.Add("IT");
            Options.Add("HR");
            Options.Add("Data scientist");
            Options.Add("Systems analyst");
            Options.Add("Full-stack developer");
            Options.Add("Full-stack developer");
            Options.Add("Database administrator");
            ViewData["Options"] = new SelectList(Options);

            return View();
        }
        [HttpPost]
        public IActionResult EmployeeDetails(IFormCollection fc, ICollection<string> shift)
        {
            ViewBag.firstname = fc["firstname"];
            ViewBag.lastname = fc["lastname"];
            ViewBag.phone = fc["phone"];
            ViewBag.salary = fc["salary"];
            ViewBag.gender = fc["gender"];
            ViewBag.shift = shift;
            ViewBag.options = fc["options"];

            return View("EmpDetails");
        }
    }
}
