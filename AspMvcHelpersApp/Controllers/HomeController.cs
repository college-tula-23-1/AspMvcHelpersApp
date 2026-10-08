using AspMvcHelpersApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace AspMvcHelpersApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["CityListTitle"] = "Cities";
            ViewData["CityList"] = new string[] { "Moscow", "Kazan", "Novosibirsk" };

            ViewData["LangsListTitle"] = "Languages";
            ViewData["LangsList"] = new string[] { "C++", "Java", "Go", "Piton", "C#" };

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            IEnumerable<Company> companies = new List<Company>()
                {
                    new(1, "Yandex"),
                    new(2, "Ozon"),
                    new(3, "Rambler"),
                };
            ViewBag.Companies = new SelectList(companies, "Id", "Title");
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            return View(employee);
        }

        public IActionResult About()
        {
            return View();
        }
    }

    record class Company(int Id, string Title);
}
