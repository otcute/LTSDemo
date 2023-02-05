using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJLAServices.Migrations
{
    /// <inheritdoc />
    public partial class cre : Migration
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
                name: "employeeLA",
                columns: table => new
                {
                    EmployeeLAId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeLAUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLAPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    EmployeeRoleId = table.Column<int>(type: "int", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    NumberPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkyUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLAName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLABirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeStatusId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_employeeLA_employeeStatuses_EmployeeStatusId",
                        column: x => x.EmployeeStatusId,
                        principalTable: "employeeStatuses",
                        principalColumn: "EmployeeStatusId");
                    table.ForeignKey(
                        name: "FK_employeeLA_genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "genders",
                        principalColumn: "GenderId");
                });

            migrationBuilder.CreateTable(
                name: "studentLAs",
                columns: table => new
                {
                    StudentLAId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLAUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLAPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    StudentLABirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SaleId = table.Column<int>(type: "int", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    StudentStatusId = table.Column<int>(type: "int", nullable: true),
                    HolidayTotal = table.Column<float>(type: "real", nullable: true),
                    ReserveTotal = table.Column<float>(type: "real", nullable: true),
                    UnauthorizedAbsencesTotal = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentLAs", x => x.StudentLAId);
                    table.ForeignKey(
                        name: "FK_studentLAs_address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "address",
                        principalColumn: "AddressId");
                    table.ForeignKey(
                        name: "FK_studentLAs_employeeLA_SaleId",
                        column: x => x.SaleId,
                        principalTable: "employeeLA",
                        principalColumn: "EmployeeLAId");
                    table.ForeignKey(
                        name: "FK_studentLAs_genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "genders",
                        principalColumn: "GenderId");
                    table.ForeignKey(
                        name: "FK_studentLAs_studentStatuses_StudentStatusId",
                        column: x => x.StudentStatusId,
                        principalTable: "studentStatuses",
                        principalColumn: "StudentStatusId");
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
                    EmployeeComfirmEmployeeLAId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_holidays", x => x.HolidayId);
                    table.ForeignKey(
                        name: "FK_holidays_employeeLA_EmployeeComfirmEmployeeLAId",
                        column: x => x.EmployeeComfirmEmployeeLAId,
                        principalTable: "employeeLA",
                        principalColumn: "EmployeeLAId");
                    table.ForeignKey(
                        name: "FK_holidays_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
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
                    EmployeeComfirmEmployeeLAId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reserves", x => x.ReserveId);
                    table.ForeignKey(
                        name: "FK_reserves_employeeLA_EmployeeComfirmEmployeeLAId",
                        column: x => x.EmployeeComfirmEmployeeLAId,
                        principalTable: "employeeLA",
                        principalColumn: "EmployeeLAId");
                    table.ForeignKey(
                        name: "FK_reserves_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "StudentLAId");
                });

            migrationBuilder.CreateTable(
                name: "studentCourses",
                columns: table => new
                {
                    StudentCourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_studentCourses_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "StudentLAId");
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
                    EmployeeComfirmEmployeeLAId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unauthorizedAbsences", x => x.UnauthorizedAbsencesId);
                    table.ForeignKey(
                        name: "FK_unauthorizedAbsences_employeeLA_EmployeeComfirmEmployeeLAId",
                        column: x => x.EmployeeComfirmEmployeeLAId,
                        principalTable: "employeeLA",
                        principalColumn: "EmployeeLAId");
                    table.ForeignKey(
                        name: "FK_unauthorizedAbsences_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "StudentLAId");
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
                name: "IX_employeeLA_EmployeeStatusId",
                table: "employeeLA",
                column: "EmployeeStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_employeeLA_GenderId",
                table: "employeeLA",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_holidays_EmployeeComfirmEmployeeLAId",
                table: "holidays",
                column: "EmployeeComfirmEmployeeLAId");

            migrationBuilder.CreateIndex(
                name: "IX_holidays_StudentLAId",
                table: "holidays",
                column: "StudentLAId");

            migrationBuilder.CreateIndex(
                name: "IX_reserves_EmployeeComfirmEmployeeLAId",
                table: "reserves",
                column: "EmployeeComfirmEmployeeLAId");

            migrationBuilder.CreateIndex(
                name: "IX_reserves_StudentLAId",
                table: "reserves",
                column: "StudentLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentCourses_CourseLAId",
                table: "studentCourses",
                column: "CourseLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentCourses_StudentLAId",
                table: "studentCourses",
                column: "StudentLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_AddressId",
                table: "studentLAs",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_GenderId",
                table: "studentLAs",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_SaleId",
                table: "studentLAs",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_StudentStatusId",
                table: "studentLAs",
                column: "StudentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_unauthorizedAbsences_EmployeeComfirmEmployeeLAId",
                table: "unauthorizedAbsences",
                column: "EmployeeComfirmEmployeeLAId");

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
                name: "holidays");

            migrationBuilder.DropTable(
                name: "reserves");

            migrationBuilder.DropTable(
                name: "studentCourses");

            migrationBuilder.DropTable(
                name: "unauthorizedAbsences");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "studentLAs");

            migrationBuilder.DropTable(
                name: "employeeLA");

            migrationBuilder.DropTable(
                name: "studentStatuses");

            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "employeeRoles");

            migrationBuilder.DropTable(
                name: "employeeStatuses");

            migrationBuilder.DropTable(
                name: "genders");
        }
    }
}
