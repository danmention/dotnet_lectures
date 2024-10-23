using Microsoft.AspNetCore.Mvc;

namespace Daniel.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {

            return View();
        }

        public IActionResult Address(string? linkedin, string? email)
        {
            
            ViewData["email"] = email;
            ViewData["linkedin"] = linkedin;

            return View();
        }
    }
}
