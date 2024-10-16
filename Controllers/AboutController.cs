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

            //create a company controller that has two routes
            //e.g company/profile and company/address

            //profile page should show random html information
            //address should take two parameters namely linkedin and email
            //display both in the resulting html page

            ViewData["name"] = name;
            return View("~/Views/About/Rat.cshtml");
        }

        //model binding
        //[FromQuery] [FromBody] [FromHeaders] [FromForm]
        public IActionResult Profile([FromQuery] UserProfile profile)
        {
            ViewData["name"] = JsonSerializer.Serialize(profile);
            return View("~/Views/About/Profile.cshtml");
        }
    }
}
