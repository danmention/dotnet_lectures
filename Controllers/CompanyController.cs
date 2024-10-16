using Microsoft.AspNetCore.Mvc;

namespace Daniel.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
