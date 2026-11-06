using Microsoft.AspNetCore.Mvc;

namespace githubhosting.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
