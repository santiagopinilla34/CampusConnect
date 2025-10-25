using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CampusConnect.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Instructor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StudentsEnrolled = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Program = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GPA = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Code", "Instructor", "StudentsEnrolled", "Title" },
                values: new object[,]
                {
                    { 1, "COMP 232", "Dr. Li", 0, "Mathematics for Computer Science" },
                    { 2, "COMP 248", "Prof. Smith", 0, "Object-Oriented Programming I" },
                    { 3, "COMP 249", "Prof. Miller", 0, "Object-Oriented Programming II" },
                    { 4, "COMP 335", "Dr. Chen", 0, "Introduction to Theoretical Computer Science" },
                    { 5, "COMP 346", "Dr. Johnson", 0, "Operating Systems" },
                    { 6, "COMP 348", "Prof. White", 0, "Principles of Programming Languages" },
                    { 7, "COMP 352", "Dr. Thompson", 0, "Data Structures and Algorithms" },
                    { 8, "COMP 354", "Dr. Davis", 0, "Introduction to Software Engineering" },
                    { 9, "COMP 376", "Prof. Garcia", 0, "Introduction to Game Development" },
                    { 10, "COMP 426", "Dr. Patel", 0, "Artificial Intelligence" },
                    { 11, "COMP 472", "Dr. Ahmed", 0, "Machine Learning" },
                    { 12, "COMP 445", "Dr. Walker", 0, "Data Communication and Networks" },
                    { 13, "COMP 428", "Prof. Roberts", 0, "Computer Graphics" },
                    { 14, "COMP 465", "Dr. Evans", 0, "Web Services and Applications" },
                    { 15, "COMP 490", "Dr. Wilson", 0, "Capstone Project" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Email", "FirstName", "GPA", "LastName", "Program" },
                values: new object[,]
                {
                    { 1, "alice.smith@example.com", "Alice", 3.7999999999999998, "Smith", "Computer Science" },
                    { 2, "bob.johnson@example.com", "Bob", 3.5, "Johnson", "Software Engineering" },
                    { 3, "charlie.williams@example.com", "Charlie", 3.8999999999999999, "Williams", "Computer Science" },
                    { 4, "david.jones@example.com", "David", 3.6000000000000001, "Jones", "Information Systems Security" },
                    { 5, "eva.brown@example.com", "Eva", 3.7000000000000002, "Brown", "Data Science" },
                    { 6, "liam.miller@example.com", "Liam", 3.3999999999999999, "Miller", "Software Engineering" },
                    { 7, "sophia.davis@example.com", "Sophia", 3.8999999999999999, "Davis", "Computer Science" },
                    { 8, "noah.wilson@example.com", "Noah", 3.2000000000000002, "Wilson", "Data Science" },
                    { 9, "olivia.taylor@example.com", "Olivia", 3.6000000000000001, "Taylor", "Software Engineering" },
                    { 10, "ethan.anderson@example.com", "Ethan", 3.2999999999999998, "Anderson", "Information Systems Security" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseId",
                table: "Enrollments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentId",
                table: "Enrollments",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
