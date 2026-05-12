using Microsoft.AspNetCore.Mvc;
using MvcUserApp.Models;

namespace MvcUserApp.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            return View("Result", user);
        }
    }
}
