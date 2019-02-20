using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestIisIntegration.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.TestKey = HttpContext.Session.GetString("TestKey");
            ViewBag.UserName = User.Identity.Name;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
