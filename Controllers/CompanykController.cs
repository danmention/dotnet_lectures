using Microsoft.AspNetCore.Mvc;

namespace Daniel.Controllers
{
    public class CompanykController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
