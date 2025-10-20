using Microsoft.EntityFrameworkCore;
using CampusConnect.Mode // Replace 'CampusConnect' with your actual project namespace

namespace CampusConnect.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // 🧱 Example DbSets (we’ll add real ones later)
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}