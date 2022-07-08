using Microsoft.AspNetCore.Mvc;
using SampleMVCwebAPP.Models;

namespace SampleMVCwebAPP.Controllers
{
    public class BookController : Controller
    {
        public IActionResult BookEntry()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BookEntry(Book book)
        {
            return View();
        }
    }
}
