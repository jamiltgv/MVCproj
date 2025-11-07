using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyMVC.Models;

namespace MyMVC.Controllers
{
    public class InformationController : Controller
    {
        private readonly ApplicationContext _context;
        public InformationController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult People()
        {
            var people = _context.People.ToList();
            return View(people);
        }

        public IActionResult Products()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public IActionResult Categories()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }


    }
}
