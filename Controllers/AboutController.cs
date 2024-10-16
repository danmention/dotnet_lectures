using Daniel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Daniel.Controllers
{
    //about/methodname
    public class AboutController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Details()
        {
            return View();
        }

        //MVC MOdel View Controller
        public IActionResult Plank(string? name, string? tribe, string? country)
        {
            //Daniel assignment use ViewBag and find out
            //the difference between ViewBag and ViewData

            // create a basic .net mvc with a controller names People
            //and a method called details that takes a string name

            ViewData["name"] = name;
            return View("~/Views/About/Rat.cshtml");
        }

        //model binding
        //[FromQuery] [FromBody] [FromHeaders] [FromForm]
        public IActionResult Profile([FromQuery] UserProfile profile)
        {
            //Daniel assignment use ViewBag and find out
            //the difference between ViewBag and ViewData

            // create a basic .net mvc with a controller names People
            //and a method called details that takes a string name

            ViewData["name"] = JsonSerializer.Serialize(profile);
            return View("~/Views/About/Profile.cshtml");
        }
    }
}
