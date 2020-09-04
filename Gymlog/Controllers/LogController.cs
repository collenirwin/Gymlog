using Microsoft.AspNetCore.Mvc;

namespace Gymlog.Controllers
{
    public class LogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
