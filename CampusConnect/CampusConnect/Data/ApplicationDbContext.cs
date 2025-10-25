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
                new Student { StudentId = 10, FirstName = "Ethan", LastName = "Anderson", Email = "ethan.anderson@example.com", GPA = 3.3, Program = "Information Systems Security" }
            );

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

            builder.Entity<Enrollment>().HasData(
                // Alice (StudentId = 1)
                new Enrollment { EnrollmentId = 1, StudentId = 1, CourseId = 1, Grade = 90 },
                new Enrollment { EnrollmentId = 2, StudentId = 1, CourseId = 2, Grade = 85 },

                // Bob (StudentId = 2)
                new Enrollment { EnrollmentId = 3, StudentId = 2, CourseId = 2, Grade = 88 },
                new Enrollment { EnrollmentId = 4, StudentId = 2, CourseId = 3, Grade = 92 },

                // Charlie (StudentId = 3)
                new Enrollment { EnrollmentId = 5, StudentId = 3, CourseId = 1, Grade = 95 },
                new Enrollment { EnrollmentId = 6, StudentId = 3, CourseId = 3, Grade = 89 },

                // David (StudentId = 4)
                new Enrollment { EnrollmentId = 7, StudentId = 4, CourseId = 4, Grade = 80 },
                new Enrollment { EnrollmentId = 8, StudentId = 4, CourseId = 5, Grade = 84 },

                // Eva (StudentId = 5)
                new Enrollment { EnrollmentId = 9, StudentId = 5, CourseId = 1, Grade = 91 },
                new Enrollment { EnrollmentId = 10, StudentId = 5, CourseId = 6, Grade = 87 },

                // Liam (StudentId = 6)
                new Enrollment { EnrollmentId = 11, StudentId = 6, CourseId = 7, Grade = 82 },
                new Enrollment { EnrollmentId = 12, StudentId = 6, CourseId = 8, Grade = 79 },

                // Sophia (StudentId = 7)
                new Enrollment { EnrollmentId = 13, StudentId = 7, CourseId = 2, Grade = 94 },
                new Enrollment { EnrollmentId = 14, StudentId = 7, CourseId = 4, Grade = 88 },

                // Noah (StudentId = 8)
                new Enrollment { EnrollmentId = 15, StudentId = 8, CourseId = 5, Grade = 85 },
                new Enrollment { EnrollmentId = 16, StudentId = 8, CourseId = 6, Grade = 90 },

                // Olivia (StudentId = 9)
                new Enrollment { EnrollmentId = 17, StudentId = 9, CourseId = 3, Grade = 87 },
                new Enrollment { EnrollmentId = 18, StudentId = 9, CourseId = 7, Grade = 82 },

                // Ethan (StudentId = 10)
                new Enrollment { EnrollmentId = 19, StudentId = 10, CourseId = 8, Grade = 86 },
                new Enrollment { EnrollmentId = 20, StudentId = 10, CourseId = 9, Grade = 90 }
            );
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}