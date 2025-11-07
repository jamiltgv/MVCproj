using Microsoft.AspNetCore.Mvc;
using MyMVC.Models;

namespace MyMVC.Controllers
{
    public class ManagementController : Controller
    {
        private readonly ApplicationContext _context;

        public ManagementController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Management()
        {
            return View();
        }
    }
}
