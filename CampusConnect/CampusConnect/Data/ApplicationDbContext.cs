using CampusConnect.Models; 
using Microsoft.EntityFrameworkCore;

namespace CampusConnect.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // 30 Students
            builder.Entity<Student>().HasData(
                new Student { StudentId = 1, FirstName = "Alice", LastName = "Smith", Email = "alice.smith@example.com", GPA = 3.8, Program = "Computer Science" },
                new Student { StudentId = 2, FirstName = "Bob", LastName = "Johnson", Email = "bob.johnson@example.com", GPA = 3.5, Program = "Software Engineering" },
                new Student { StudentId = 3, FirstName = "Charlie", LastName = "Williams", Email = "charlie.williams@example.com", GPA = 3.9, Program = "Computer Science" },
                new Student { StudentId = 4, FirstName = "David", LastName = "Jones", Email = "david.jones@example.com", GPA = 3.6, Program = "Information Systems Security" },
                new Student { StudentId = 5, FirstName = "Eva", LastName = "Brown", Email = "eva.brown@example.com", GPA = 3.7, Program = "Data Science" },
                new Student { StudentId = 6, FirstName = "Liam", LastName = "Miller", Email = "liam.miller@example.com", GPA = 3.4, Program = "Software Engineering" },
                new Student { StudentId = 7, FirstName = "Sophia", LastName = "Davis", Email = "sophia.davis@example.com", GPA = 3.9, Program = "Computer Science" },
                new Student { StudentId = 8, FirstName = "Noah", LastName = "Wilson", Email = "noah.wilson@example.com", GPA = 3.2, Program = "Data Science" },
                new Student { StudentId = 9, FirstName = "Olivia", LastName = "Taylor", Email = "olivia.taylor@example.com", GPA = 3.6, Program = "Software Engineering" },
                new Student { StudentId = 10, FirstName = "Ethan", LastName = "Anderson", Email = "ethan.anderson@example.com", GPA = 3.3, Program = "Information Systems Security" },
                new Student { StudentId = 11, FirstName = "Mia", LastName = "Thomas", Email = "mia.thomas@example.com", GPA = 3.5, Program = "Computer Science" },
                new Student { StudentId = 12, FirstName = "Jacob", LastName = "Lee", Email = "jacob.lee@example.com", GPA = 3.6, Program = "Software Engineering" },
                new Student { StudentId = 13, FirstName = "Isabella", LastName = "White", Email = "isabella.white@example.com", GPA = 3.8, Program = "Data Science" },
                new Student { StudentId = 14, FirstName = "William", LastName = "Harris", Email = "william.harris@example.com", GPA = 3.4, Program = "Computer Science" },
                new Student { StudentId = 15, FirstName = "Emily", LastName = "Clark", Email = "emily.clark@example.com", GPA = 3.7, Program = "Software Engineering" },
                new Student { StudentId = 16, FirstName = "James", LastName = "Lewis", Email = "james.lewis@example.com", GPA = 3.3, Program = "Data Science" },
                new Student { StudentId = 17, FirstName = "Ava", LastName = "Robinson", Email = "ava.robinson@example.com", GPA = 3.9, Program = "Information Systems Security" },
                new Student { StudentId = 18, FirstName = "Michael", LastName = "Walker", Email = "michael.walker@example.com", GPA = 3.2, Program = "Computer Science" },
                new Student { StudentId = 19, FirstName = "Charlotte", LastName = "Hall", Email = "charlotte.hall@example.com", GPA = 3.6, Program = "Software Engineering" },
                new Student { StudentId = 20, FirstName = "Alexander", LastName = "Allen", Email = "alexander.allen@example.com", GPA = 3.5, Program = "Data Science" },
                new Student { StudentId = 21, FirstName = "Ella", LastName = "Young", Email = "ella.young@example.com", GPA = 3.7, Program = "Computer Science" },
                new Student { StudentId = 22, FirstName = "Daniel", LastName = "King", Email = "daniel.king@example.com", GPA = 3.4, Program = "Software Engineering" },
                new Student { StudentId = 23, FirstName = "Amelia", LastName = "Wright", Email = "amelia.wright@example.com", GPA = 3.9, Program = "Data Science" },
                new Student { StudentId = 24, FirstName = "Matthew", LastName = "Scott", Email = "matthew.scott@example.com", GPA = 3.3, Program = "Information Systems Security" },
                new Student { StudentId = 25, FirstName = "Harper", LastName = "Green", Email = "harper.green@example.com", GPA = 3.6, Program = "Computer Science" },
                new Student { StudentId = 26, FirstName = "Joseph", LastName = "Adams", Email = "joseph.adams@example.com", GPA = 3.5, Program = "Software Engineering" },
                new Student { StudentId = 27, FirstName = "Evelyn", LastName = "Baker", Email = "evelyn.baker@example.com", GPA = 3.8, Program = "Data Science" },
                new Student { StudentId = 28, FirstName = "Samuel", LastName = "Gonzalez", Email = "samuel.gonzalez@example.com", GPA = 3.4, Program = "Computer Science" },
                new Student { StudentId = 29, FirstName = "Elizabeth", LastName = "Nelson", Email = "elizabeth.nelson@example.com", GPA = 3.7, Program = "Software Engineering" },
                new Student { StudentId = 30, FirstName = "David", LastName = "Carter", Email = "david.carter@example.com", GPA = 3.3, Program = "Data Science" }
            );

            // 15 Courses
            builder.Entity<Course>().HasData(
                new Course { CourseId = 1, Code = "COMP 232", Title = "Mathematics for Computer Science", Instructor = "Dr. Li", StudentsEnrolled = 0 },
                new Course { CourseId = 2, Code = "COMP 248", Title = "Object-Oriented Programming I", Instructor = "Prof. Smith", StudentsEnrolled = 0 },
                new Course { CourseId = 3, Code = "COMP 249", Title = "Object-Oriented Programming II", Instructor = "Prof. Miller", StudentsEnrolled = 0 },
                new Course { CourseId = 4, Code = "COMP 335", Title = "Introduction to Theoretical Computer Science", Instructor = "Dr. Chen", StudentsEnrolled = 0 },
                new Course { CourseId = 5, Code = "COMP 346", Title = "Operating Systems", Instructor = "Dr. Johnson", StudentsEnrolled = 0 },
                new Course { CourseId = 6, Code = "COMP 348", Title = "Principles of Programming Languages", Instructor = "Prof. White", StudentsEnrolled = 0 },
                new Course { CourseId = 7, Code = "COMP 352", Title = "Data Structures and Algorithms", Instructor = "Dr. Thompson", StudentsEnrolled = 0 },
                new Course { CourseId = 8, Code = "COMP 354", Title = "Introduction to Software Engineering", Instructor = "Dr. Davis", StudentsEnrolled = 0 },
                new Course { CourseId = 9, Code = "COMP 376", Title = "Introduction to Game Development", Instructor = "Prof. Garcia", StudentsEnrolled = 0 },
                new Course { CourseId = 10, Code = "COMP 426", Title = "Artificial Intelligence", Instructor = "Dr. Patel", StudentsEnrolled = 0 },
                new Course { CourseId = 11, Code = "COMP 472", Title = "Machine Learning", Instructor = "Dr. Ahmed", StudentsEnrolled = 0 },
                new Course { CourseId = 12, Code = "COMP 445", Title = "Data Communication and Networks", Instructor = "Dr. Walker", StudentsEnrolled = 0 },
                new Course { CourseId = 13, Code = "COMP 428", Title = "Computer Graphics", Instructor = "Prof. Roberts", StudentsEnrolled = 0 },
                new Course { CourseId = 14, Code = "COMP 465", Title = "Web Services and Applications", Instructor = "Dr. Evans", StudentsEnrolled = 0 },
                new Course { CourseId = 15, Code = "COMP 490", Title = "Capstone Project", Instructor = "Dr. Wilson", StudentsEnrolled = 0 }
            );

            // 60 Enrollments (2 courses per student)
            builder.Entity<Enrollment>().HasData(
                new Enrollment { EnrollmentId = 1, StudentId = 1, CourseId = 1, Grade = 90 },
                new Enrollment { EnrollmentId = 2, StudentId = 1, CourseId = 2, Grade = 85 },
                new Enrollment { EnrollmentId = 3, StudentId = 2, CourseId = 2, Grade = 88 },
                new Enrollment { EnrollmentId = 4, StudentId = 2, CourseId = 3, Grade = 92 },
                new Enrollment { EnrollmentId = 5, StudentId = 3, CourseId = 1, Grade = 95 },
                new Enrollment { EnrollmentId = 6, StudentId = 3, CourseId = 3, Grade = 89 },
                new Enrollment { EnrollmentId = 7, StudentId = 4, CourseId = 4, Grade = 80 },
                new Enrollment { EnrollmentId = 8, StudentId = 4, CourseId = 5, Grade = 84 },
                new Enrollment { EnrollmentId = 9, StudentId = 5, CourseId = 1, Grade = 91 },
                new Enrollment { EnrollmentId = 10, StudentId = 5, CourseId = 6, Grade = 87 },
                new Enrollment { EnrollmentId = 11, StudentId = 6, CourseId = 7, Grade = 82 },
                new Enrollment { EnrollmentId = 12, StudentId = 6, CourseId = 8, Grade = 79 },
                new Enrollment { EnrollmentId = 13, StudentId = 7, CourseId = 2, Grade = 94 },
                new Enrollment { EnrollmentId = 14, StudentId = 7, CourseId = 4, Grade = 88 },
                new Enrollment { EnrollmentId = 15, StudentId = 8, CourseId = 5, Grade = 85 },
                new Enrollment { EnrollmentId = 16, StudentId = 8, CourseId = 6, Grade = 90 },
                new Enrollment { EnrollmentId = 17, StudentId = 9, CourseId = 3, Grade = 87 },
                new Enrollment { EnrollmentId = 18, StudentId = 9, CourseId = 7, Grade = 82 },
                new Enrollment { EnrollmentId = 19, StudentId = 10, CourseId = 8, Grade = 86 },
                new Enrollment { EnrollmentId = 20, StudentId = 10, CourseId = 9, Grade = 90 },
                new Enrollment { EnrollmentId = 21, StudentId = 11, CourseId = 1, Grade = 88 },
                new Enrollment { EnrollmentId = 22, StudentId = 11, CourseId = 2, Grade = 91 },
                new Enrollment { EnrollmentId = 23, StudentId = 12, CourseId = 3, Grade = 85 },
                new Enrollment { EnrollmentId = 24, StudentId = 12, CourseId = 4, Grade = 87 },
                new Enrollment { EnrollmentId = 25, StudentId = 13, CourseId = 5, Grade = 90 },
                new Enrollment { EnrollmentId = 26, StudentId = 13, CourseId = 6, Grade = 92 },
                new Enrollment { EnrollmentId = 27, StudentId = 14, CourseId = 7, Grade = 83 },
                new Enrollment { EnrollmentId = 28, StudentId = 14, CourseId = 8, Grade = 81 },
                new Enrollment { EnrollmentId = 29, StudentId = 15, CourseId = 9, Grade = 88 },
                new Enrollment { EnrollmentId = 30, StudentId = 15, CourseId = 10, Grade = 84 },
                new Enrollment { EnrollmentId = 31, StudentId = 16, CourseId = 11, Grade = 86 },
                new Enrollment { EnrollmentId = 32, StudentId = 16, CourseId = 12, Grade = 82 },
                new Enrollment { EnrollmentId = 33, StudentId = 17, CourseId = 13, Grade = 91 },
                new Enrollment { EnrollmentId = 34, StudentId = 17, CourseId = 14, Grade = 89 },
                new Enrollment { EnrollmentId = 35, StudentId = 18, CourseId = 15, Grade = 87 },
                new Enrollment { EnrollmentId = 36, StudentId = 18, CourseId = 1, Grade = 85 },
                new Enrollment { EnrollmentId = 37, StudentId = 19, CourseId = 2, Grade = 90 },
                new Enrollment { EnrollmentId = 38, StudentId = 19, CourseId = 3, Grade = 88 },
                new Enrollment { EnrollmentId = 39, StudentId = 20, CourseId = 4, Grade = 92 },
                new Enrollment { EnrollmentId = 40, StudentId = 20, CourseId = 5, Grade = 89 },
                new Enrollment { EnrollmentId = 41, StudentId = 21, CourseId = 6, Grade = 84 },
                new Enrollment { EnrollmentId = 42, StudentId = 21, CourseId = 7, Grade = 86 },
                new Enrollment { EnrollmentId = 43, StudentId = 22, CourseId = 8, Grade = 83 },
                new Enrollment { EnrollmentId = 44, StudentId = 22, CourseId = 9, Grade = 81 },
                new Enrollment { EnrollmentId = 45, StudentId = 23, CourseId = 10, Grade = 88 },
                new Enrollment { EnrollmentId = 46, StudentId = 23, CourseId = 11, Grade = 90 },
                new Enrollment { EnrollmentId = 47, StudentId = 24, CourseId = 12, Grade = 85 },
                new Enrollment { EnrollmentId = 48, StudentId = 24, CourseId = 13, Grade = 87 },
                new Enrollment { EnrollmentId = 49, StudentId = 25, CourseId = 14, Grade = 91 },
                new Enrollment { EnrollmentId = 50, StudentId = 25, CourseId = 15, Grade = 89 },
                new Enrollment { EnrollmentId = 51, StudentId = 26, CourseId = 1, Grade = 83 },
                new Enrollment { EnrollmentId = 52, StudentId = 26, CourseId = 2, Grade = 85 },
                new Enrollment { EnrollmentId = 53, StudentId = 27, CourseId = 3, Grade = 88 },
                new Enrollment { EnrollmentId = 54, StudentId = 27, CourseId = 4, Grade = 90 },
                new Enrollment { EnrollmentId = 55, StudentId = 28, CourseId = 5, Grade = 84 },
                new Enrollment { EnrollmentId = 56, StudentId = 28, CourseId = 6, Grade = 82 },
                new Enrollment { EnrollmentId = 57, StudentId = 29, CourseId = 7, Grade = 87 },
                new Enrollment { EnrollmentId = 58, StudentId = 29, CourseId = 8, Grade = 85 },
                new Enrollment { EnrollmentId = 59, StudentId = 30, CourseId = 9, Grade = 89 },
                new Enrollment { EnrollmentId = 60, StudentId = 30, CourseId = 10, Grade = 90 }
            );
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<User> Users { get; set; }
    }
}