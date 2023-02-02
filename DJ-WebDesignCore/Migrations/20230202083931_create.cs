using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJWebDesignCore.Migrations
{
    /// <inheritdoc />
    public partial class create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommuneId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    CourseLAId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseLACode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseLAName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseLAPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.CourseLAId);
                });

            migrationBuilder.CreateTable(
                name: "employeeRoles",
                columns: table => new
                {
                    EmployeeRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeRoleCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeRoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeRoles", x => x.EmployeeRoleId);
                });

            migrationBuilder.CreateTable(
                name: "genders",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genders", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "employeeLA",
                columns: table => new
                {
                    EmployeeLAId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    EmployeeRoleId = table.Column<int>(type: "int", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    NumberPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkyUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLAName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLABirthDay = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeLA", x => x.EmployeeLAId);
                    table.ForeignKey(
                        name: "FK_employeeLA_address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "address",
                        principalColumn: "AddressId");
                    table.ForeignKey(
                        name: "FK_employeeLA_employeeRoles_EmployeeRoleId",
                        column: x => x.EmployeeRoleId,
                        principalTable: "employeeRoles",
                        principalColumn: "EmployeeRoleId");
                    table.ForeignKey(
                        name: "FK_employeeLA_genders_EmployeeRoleId",
                        column: x => x.EmployeeRoleId,
                        principalTable: "genders",
                        principalColumn: "GenderId");
                });

            migrationBuilder.CreateTable(
                name: "studentCourses",
                columns: table => new
                {
                    StudentCourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    CourseLAId = table.Column<int>(type: "int", nullable: true),
                    OpenCourse = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CloseCourse = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentCourses", x => x.StudentCourseId);
                    table.ForeignKey(
                        name: "FK_studentCourses_courses_CourseLAId",
                        column: x => x.CourseLAId,
                        principalTable: "courses",
                        principalColumn: "CourseLAId");
                    table.ForeignKey(
                        name: "FK_studentCourses_employeeLA_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employeeLA",
                        principalColumn: "EmployeeLAId");
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    StudentBirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SaleId = table.Column<int>(type: "int", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_students_address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "address",
                        principalColumn: "AddressId");
                    table.ForeignKey(
                        name: "FK_students_employeeLA_SaleId",
                        column: x => x.SaleId,
                        principalTable: "employeeLA",
                        principalColumn: "EmployeeLAId");
                    table.ForeignKey(
                        name: "FK_students_genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "genders",
                        principalColumn: "GenderId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_employeeLA_AddressId",
                table: "employeeLA",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_employeeLA_EmployeeRoleId",
                table: "employeeLA",
                column: "EmployeeRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_studentCourses_CourseLAId",
                table: "studentCourses",
                column: "CourseLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentCourses_EmployeeId",
                table: "studentCourses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_students_AddressId",
                table: "students",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_students_GenderId",
                table: "students",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_students_SaleId",
                table: "students",
                column: "SaleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentCourses");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "employeeLA");

            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "employeeRoles");

            migrationBuilder.DropTable(
                name: "genders");
        }
    }
}
