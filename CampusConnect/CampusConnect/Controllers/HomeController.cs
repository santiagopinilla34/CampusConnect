using CampusConnect.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CampusConnect.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Get real statistics
            var activeStudents = _context.Students.Count();
            var totalCourses = _context.Courses.Count();
            var totalEnrollments = _context.Enrollments.Count();

            // Pass to view using ViewData or a ViewModel
            ViewData["ActiveStudents"] = activeStudents;
            ViewData["TotalCourses"] = totalCourses;
            ViewData["TotalEnrollments"] = totalEnrollments;

            return View();
        }
    }
}