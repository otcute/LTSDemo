using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJUseCaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class updatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAccountDatetime",
                table: "studentLAs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentLASdt",
                table: "studentLAs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkStudentTest",
                table: "studentLACourseLessons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupportMonth",
                table: "studentCourses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupportMonth",
                table: "courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SortNumber",
                table: "courseLessons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "studentEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    EmployeeLAId = table.Column<int>(type: "int", nullable: true),
                    SetMentorDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChangeReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentEmployees_employeeLA_EmployeeLAId",
                        column: x => x.EmployeeLAId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentEmployees_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_studentEmployees_EmployeeLAId",
                table: "studentEmployees",
                column: "EmployeeLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentEmployees_StudentLAId",
                table: "studentEmployees",
                column: "StudentLAId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentEmployees");

            migrationBuilder.DropColumn(
                name: "CreateAccountDatetime",
                table: "studentLAs");

            migrationBuilder.DropColumn(
                name: "StudentLASdt",
                table: "studentLAs");

            migrationBuilder.DropColumn(
                name: "LinkStudentTest",
                table: "studentLACourseLessons");

            migrationBuilder.DropColumn(
                name: "SupportMonth",
                table: "studentCourses");

            migrationBuilder.DropColumn(
                name: "SupportMonth",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "SortNumber",
                table: "courseLessons");
        }
    }
}
