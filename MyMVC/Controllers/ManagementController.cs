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


        // -- вьюшки --


        public IActionResult Index()
        {
            return View();
        }

        // products

        public IActionResult Products()
        {
            return View("Products/Index");
        }
        
        // people

        public IActionResult People()
        {
            return View("People/Index");
        }
        public IActionResult CreatePeople()
        {
            return View("People/Create");
        }
        public IActionResult UpdatePeople()
        {
            var people = _context.People.ToList();
            return View("People/Update", people);
        }

        // categories

        public IActionResult Categories()
        {
            return View("Categories/Index");
        }

        // message

        public IActionResult Success()
        {
            return Content("Success!");
        }
        public IActionResult NotFound()
        {
            return Content("404. User was not found.");
        }


        // -- логика (CRUD) --


        [HttpPost]
        public async Task<IActionResult> AddEmp(People employee)
        {
            _context.People.Add(employee);
            await _context.SaveChangesAsync();
            return View("People/Index");
        }

        [HttpPost]
        public async Task<IActionResult> DelEmp(int? id)
        {
            if(id != null)
            {
                var employee = _context.People.FirstOrDefault(p => p.Id == id);
                if(employee != null)
                {
                    _context.People.Remove(employee);
                    await _context.SaveChangesAsync();
                    return View("People/Index");
                }
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult UpdEmp(int id)
        {
            if(id != null)
                return RedirectToAction("EditPeople", new { id = id });
            return NotFound();
        }

        public IActionResult EditPeople(int id)
        {
            var employee = _context.People.FirstOrDefault(p => p.Id == id);
            if (employee == null) return NotFound();

            return View("People/Edit", employee);
        }

        [HttpPost]
        public async Task<IActionResult> UpdEmp(People employee)
        {
            _context.People.Update(employee);
            await _context.SaveChangesAsync();
            return View("People/Index");
        }
    }
}
