using FrontToBackTask1.DataAccessLayer.Context;
using FrontToBackTask1.DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBackTask1.Controllers
{
    public class StudentController : Controller
    {

        private readonly AppDbContext _dbContext;

        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<Student> students = _dbContext.Students.Include(x => x.Teacher).ToList();

            return View(students);
        }
    }
}
