using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolWebAPI.Migrations
{
    public partial class EnrollmentUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Enrollments_EnrollmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Enrollments_EnrollmentId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_EnrollmentId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Courses_EnrollmentId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "EnrollmentId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "EnrollmentId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "coursescId",
                table: "Enrollments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "studentsId",
                table: "Enrollments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_coursescId",
                table: "Enrollments",
                column: "coursescId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_studentsId",
                table: "Enrollments",
                column: "studentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_coursescId",
                table: "Enrollments",
                column: "coursescId",
                principalTable: "Courses",
                principalColumn: "cId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Student_studentsId",
                table: "Enrollments",
                column: "studentsId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_coursescId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Student_studentsId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_coursescId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_studentsId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "coursescId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "studentsId",
                table: "Enrollments");

            migrationBuilder.AddColumn<int>(
                name: "EnrollmentId",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnrollmentId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_EnrollmentId",
                table: "Student",
                column: "EnrollmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_EnrollmentId",
                table: "Courses",
                column: "EnrollmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Enrollments_EnrollmentId",
                table: "Courses",
                column: "EnrollmentId",
                principalTable: "Enrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Enrollments_EnrollmentId",
                table: "Student",
                column: "EnrollmentId",
                principalTable: "Enrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
