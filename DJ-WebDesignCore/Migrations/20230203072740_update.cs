using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJWebDesignCore.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courseStatuses",
                columns: table => new
                {
                    CourseStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseStatuses", x => x.CourseStatusId);
                });

            migrationBuilder.CreateTable(
                name: "employeeStatuses",
                columns: table => new
                {
                    EmployeeStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeStatuses", x => x.EmployeeStatusId);
                });

            migrationBuilder.CreateTable(
                name: "holidays",
                columns: table => new
                {
                    HolidayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    OpenTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CloseTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDiff = table.Column<int>(type: "int", nullable: true),
                    HolidayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeComfirmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_holidays", x => x.HolidayId);
                    table.ForeignKey(
                        name: "FK_holidays_employeeLA_EmployeeComfirmId",
                        column: x => x.EmployeeComfirmId,
                        principalTable: "employeeLA",
                        principalColumn: "EmployeeLAId");
                    table.ForeignKey(
                        name: "FK_holidays_students_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "students",
                        principalColumn: "StudentLAId");
                });

            migrationBuilder.CreateTable(
                name: "reserves",
                columns: table => new
                {
                    ReserveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    OpenTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CloseTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDiff = table.Column<int>(type: "int", nullable: true),
                    ReserveReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeComfirmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reserves", x => x.ReserveId);
                    table.ForeignKey(
                        name: "FK_reserves_employeeLA_EmployeeComfirmId",
                        column: x => x.EmployeeComfirmId,
                        principalTable: "employeeLA",
                        principalColumn: "EmployeeLAId");
                    table.ForeignKey(
                        name: "FK_reserves_students_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "students",
                        principalColumn: "StudentLAId");
                });

            migrationBuilder.CreateTable(
                name: "studentStatuses",
                columns: table => new
                {
                    StudentStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentStatuses", x => x.StudentStatusId);
                });

            migrationBuilder.CreateTable(
                name: "unauthorizedAbsences",
                columns: table => new
                {
                    UnauthorizedAbsencesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    UnauthorizedAbsencesDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UnauthorizedAbsencesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeComfirmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unauthorizedAbsences", x => x.UnauthorizedAbsencesId);
                    table.ForeignKey(
                        name: "FK_unauthorizedAbsences_employeeLA_EmployeeComfirmId",
                        column: x => x.EmployeeComfirmId,
                        principalTable: "employeeLA",
                        principalColumn: "EmployeeLAId");
                    table.ForeignKey(
                        name: "FK_unauthorizedAbsences_students_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "students",
                        principalColumn: "StudentLAId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_holidays_EmployeeComfirmId",
                table: "holidays",
                column: "EmployeeComfirmId");

            migrationBuilder.CreateIndex(
                name: "IX_holidays_StudentLAId",
                table: "holidays",
                column: "StudentLAId");

            migrationBuilder.CreateIndex(
                name: "IX_reserves_EmployeeComfirmId",
                table: "reserves",
                column: "EmployeeComfirmId");

            migrationBuilder.CreateIndex(
                name: "IX_reserves_StudentLAId",
                table: "reserves",
                column: "StudentLAId");

            migrationBuilder.CreateIndex(
                name: "IX_unauthorizedAbsences_EmployeeComfirmId",
                table: "unauthorizedAbsences",
                column: "EmployeeComfirmId");

            migrationBuilder.CreateIndex(
                name: "IX_unauthorizedAbsences_StudentLAId",
                table: "unauthorizedAbsences",
                column: "StudentLAId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courseStatuses");

            migrationBuilder.DropTable(
                name: "employeeStatuses");

            migrationBuilder.DropTable(
                name: "holidays");

            migrationBuilder.DropTable(
                name: "reserves");

            migrationBuilder.DropTable(
                name: "studentStatuses");

            migrationBuilder.DropTable(
                name: "unauthorizedAbsences");
        }
    }
}
