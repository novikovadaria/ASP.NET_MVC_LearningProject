using Microsoft.AspNetCore.Mvc;
using MVCUsingExmaple.Models;

namespace MVCUsingExmaple.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<CatViewModel> cats = new List<CatViewModel>();

        public IActionResult Index()
        {
            return View(cats);
        }

        public IActionResult Create()
        {
            var catModel = new CatViewModel();
            return View(catModel);
        }

        public IActionResult CreatCat(CatViewModel catViewModel)
        {
            cats.Add(catViewModel);
            return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}
