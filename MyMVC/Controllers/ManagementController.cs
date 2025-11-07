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
        public IActionResult ManageProducts()
        {
            return View("ManageProducts/ManageProducts");
        }
        public IActionResult ManagePeople()
        {
            return View("ManagePeople/ManagePeople");
        }
        public IActionResult ManageCategories()
        {
            return View("ManageCategories/ManageCategories");
        }
        public IActionResult AddPeople()
        {
            return View("ManagePeople/AddPeople");
        }

        public IActionResult DeletePeople()
        {
            return View("ManagePeople/DeletePeople");
        }
        public IActionResult ChangePeople()
        {
            return View("ManagePeople/ChangePeople");
        }
    }
}
