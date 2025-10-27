using CampusConnect.Data;
using CampusConnect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Buffers;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CampusConnect.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index(string searchString)
        {
            var students = from s in _context.Students
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.FirstName.Contains(searchString)
                                            || s.LastName.Contains(searchString)
                                            || s.Email.Contains(searchString));
            }

            return View(await students.ToListAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var student = await _context.Students.Include(s => s.Enrollments).ThenInclude(e => e.Course).FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null) return NotFound();

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Teacher")
            {
                return RedirectToAction("AccessDenied", "Account");
            }
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Teacher")
            {
                return RedirectToAction("AccessDenied", "Account");
            }
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Teacher")
            {
                return RedirectToAction("AccessDenied", "Account");
            }
            if (id == null) return NotFound();

            var student = await _context.Students.FindAsync(id);
            if (student == null) return NotFound();

            return View(student);
        }

        // POST: Students/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Teacher")
            {
                return RedirectToAction("AccessDenied", "Account");
            }
            if (id != student.StudentId) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentId)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Teacher")
            {
                return RedirectToAction("AccessDenied", "Account");
            }
            if (id == null) return NotFound();

            var student = await _context.Students.FirstOrDefaultAsync(s => s.StudentId == id);
            if (student == null) return NotFound();

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Teacher")
            {
                return RedirectToAction("AccessDenied", "Account");
            }
            var student = await _context.Students.FindAsync(id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.StudentId == id);
        }


        public IActionResult Enroll(int id)
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Teacher")
            {
                return RedirectToAction("AccessDenied", "Account");
            }
            var student = _context.Students.Find(id);
            if (student == null) return NotFound();

            ViewBag.Courses = new SelectList(_context.Courses, "CourseId", "Title");
            return View(student);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Enroll(int studentId, int courseId, int? grade)
        {
            var role = HttpContext.Session.GetString("UserRole");
            if (role != "Teacher")
            {
                return RedirectToAction("AccessDenied", "Account");
            }
            if (!_context.Enrollments.Any(e => e.StudentId == studentId && e.CourseId == courseId))
            {
                var enrollment = new Enrollment
                {
                    StudentId = studentId,
                    CourseId = courseId, 
                    Grade =  grade ?? 0
                };
                _context.Enrollments.Add(enrollment);
                _context.SaveChanges();

            }

            return RedirectToAction(nameof(Details), new { id = studentId });
        }


    }
}