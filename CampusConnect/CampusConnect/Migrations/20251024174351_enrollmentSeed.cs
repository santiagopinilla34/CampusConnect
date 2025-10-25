using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CampusConnect.Migrations
{
    /// <inheritdoc />
    public partial class enrollmentSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 20, 9, 90, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "EnrollmentId",
                keyValue: 20);
        }
    }
}
