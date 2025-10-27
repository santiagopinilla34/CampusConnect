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
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsTeacher = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
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
                    { 10, "ethan.anderson@example.com", "Ethan", 3.2999999999999998, "Anderson", "Information Systems Security" },
                    { 11, "mia.thomas@example.com", "Mia", 3.5, "Thomas", "Computer Science" },
                    { 12, "jacob.lee@example.com", "Jacob", 3.6000000000000001, "Lee", "Software Engineering" },
                    { 13, "isabella.white@example.com", "Isabella", 3.7999999999999998, "White", "Data Science" },
                    { 14, "william.harris@example.com", "William", 3.3999999999999999, "Harris", "Computer Science" },
                    { 15, "emily.clark@example.com", "Emily", 3.7000000000000002, "Clark", "Software Engineering" },
                    { 16, "james.lewis@example.com", "James", 3.2999999999999998, "Lewis", "Data Science" },
                    { 17, "ava.robinson@example.com", "Ava", 3.8999999999999999, "Robinson", "Information Systems Security" },
                    { 18, "michael.walker@example.com", "Michael", 3.2000000000000002, "Walker", "Computer Science" },
                    { 19, "charlotte.hall@example.com", "Charlotte", 3.6000000000000001, "Hall", "Software Engineering" },
                    { 20, "alexander.allen@example.com", "Alexander", 3.5, "Allen", "Data Science" },
                    { 21, "ella.young@example.com", "Ella", 3.7000000000000002, "Young", "Computer Science" },
                    { 22, "daniel.king@example.com", "Daniel", 3.3999999999999999, "King", "Software Engineering" },
                    { 23, "amelia.wright@example.com", "Amelia", 3.8999999999999999, "Wright", "Data Science" },
                    { 24, "matthew.scott@example.com", "Matthew", 3.2999999999999998, "Scott", "Information Systems Security" },
                    { 25, "harper.green@example.com", "Harper", 3.6000000000000001, "Green", "Computer Science" },
                    { 26, "joseph.adams@example.com", "Joseph", 3.5, "Adams", "Software Engineering" },
                    { 27, "evelyn.baker@example.com", "Evelyn", 3.7999999999999998, "Baker", "Data Science" },
                    { 28, "samuel.gonzalez@example.com", "Samuel", 3.3999999999999999, "Gonzalez", "Computer Science" },
                    { 29, "elizabeth.nelson@example.com", "Elizabeth", 3.7000000000000002, "Nelson", "Software Engineering" },
                    { 30, "david.carter@example.com", "David", 3.2999999999999998, "Carter", "Data Science" }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "EnrollmentId", "CourseId", "Grade", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, 90, 1 },
                    { 2, 2, 85, 1 },
                    { 3, 2, 88, 2 },
                    { 4, 3, 92, 2 },
                    { 5, 1, 95, 3 },
                    { 6, 3, 89, 3 },
                    { 7, 4, 80, 4 },
                    { 8, 5, 84, 4 },
                    { 9, 1, 91, 5 },
                    { 10, 6, 87, 5 },
                    { 11, 7, 82, 6 },
                    { 12, 8, 79, 6 },
                    { 13, 2, 94, 7 },
                    { 14, 4, 88, 7 },
                    { 15, 5, 85, 8 },
                    { 16, 6, 90, 8 },
                    { 17, 3, 87, 9 },
                    { 18, 7, 82, 9 },
                    { 19, 8, 86, 10 },
                    { 20, 9, 90, 10 },
                    { 21, 1, 88, 11 },
                    { 22, 2, 91, 11 },
                    { 23, 3, 85, 12 },
                    { 24, 4, 87, 12 },
                    { 25, 5, 90, 13 },
                    { 26, 6, 92, 13 },
                    { 27, 7, 83, 14 },
                    { 28, 8, 81, 14 },
                    { 29, 9, 88, 15 },
                    { 30, 10, 84, 15 },
                    { 31, 11, 86, 16 },
                    { 32, 12, 82, 16 },
                    { 33, 13, 91, 17 },
                    { 34, 14, 89, 17 },
                    { 35, 15, 87, 18 },
                    { 36, 1, 85, 18 },
                    { 37, 2, 90, 19 },
                    { 38, 3, 88, 19 },
                    { 39, 4, 92, 20 },
                    { 40, 5, 89, 20 },
                    { 41, 6, 84, 21 },
                    { 42, 7, 86, 21 },
                    { 43, 8, 83, 22 },
                    { 44, 9, 81, 22 },
                    { 45, 10, 88, 23 },
                    { 46, 11, 90, 23 },
                    { 47, 12, 85, 24 },
                    { 48, 13, 87, 24 },
                    { 49, 14, 91, 25 },
                    { 50, 15, 89, 25 },
                    { 51, 1, 83, 26 },
                    { 52, 2, 85, 26 },
                    { 53, 3, 88, 27 },
                    { 54, 4, 90, 27 },
                    { 55, 5, 84, 28 },
                    { 56, 6, 82, 28 },
                    { 57, 7, 87, 29 },
                    { 58, 8, 85, 29 },
                    { 59, 9, 89, 30 },
                    { 60, 10, 90, 30 }
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
                name: "Users");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
