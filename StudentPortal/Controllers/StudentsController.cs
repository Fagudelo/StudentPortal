using Microsoft.AspNetCore.Mvc;
using StudentPortal.Data;
using StudentPortal.Models;

namespace StudentPortal.Controllers
{
    public class StudentsController(ApplicationDbContext dbContext) : Controller
    {
        private readonly ApplicationDbContext _context = dbContext;

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddStudentViewModel viewModel)
        {
            return View();
        }
    }
}
