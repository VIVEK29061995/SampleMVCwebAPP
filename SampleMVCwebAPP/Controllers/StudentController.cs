using Microsoft.AspNetCore.Mvc;
using SampleMVCwebAPP.Models;

namespace SampleMVCwebAPP.Controllers
{
    public class StudentController : Controller
    {
        //GET:Student
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            return View();
        }
    }
}
