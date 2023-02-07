using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJUseCaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class cre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "communes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommuneCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommuneName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_communes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "courseStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "districtes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_districtes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employeeRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeRoleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeRoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employeeStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "studentStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseLACode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseLAName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseLAPrice = table.Column<double>(type: "float", nullable: true),
                    CourseStatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_courses_courseStatuses_CourseStatusId",
                        column: x => x.CourseStatusId,
                        principalTable: "courseStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "employeeLA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeLAUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLAPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeRoleId = table.Column<int>(type: "int", nullable: true),
                    EmployeeAvatar = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CommuneId = table.Column<int>(type: "int", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_employeeLA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employeeLA_communes_CommuneId",
                        column: x => x.CommuneId,
                        principalTable: "communes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_employeeLA_districtes_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "districtes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_employeeLA_employeeRoles_EmployeeRoleId",
                        column: x => x.EmployeeRoleId,
                        principalTable: "employeeRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_employeeLA_employeeStatuses_EmployeeStatusId",
                        column: x => x.EmployeeStatusId,
                        principalTable: "employeeStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_employeeLA_genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "genders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_employeeLA_provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "provinces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "studentLAs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLAUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLAPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLAAvatar = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CommuneId = table.Column<int>(type: "int", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_studentLAs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentLAs_communes_CommuneId",
                        column: x => x.CommuneId,
                        principalTable: "communes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLAs_districtes_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "districtes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLAs_employeeLA_SaleId",
                        column: x => x.SaleId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLAs_genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "genders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLAs_provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "provinces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLAs_studentStatuses_StudentStatusId",
                        column: x => x.StudentStatusId,
                        principalTable: "studentStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "holidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_holidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_holidays_employeeLA_EmployeeComfirmId",
                        column: x => x.EmployeeComfirmId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_holidays_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "reserves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_reserves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reserves_employeeLA_EmployeeComfirmId",
                        column: x => x.EmployeeComfirmId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_reserves_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "studentCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    CourseLAId = table.Column<int>(type: "int", nullable: true),
                    OpenCourse = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CloseCourse = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentCourses_courses_CourseLAId",
                        column: x => x.CourseLAId,
                        principalTable: "courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentCourses_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "unauthorizedAbsences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    UnauthorizedAbsencesDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UnauthorizedAbsencesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeComfirmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unauthorizedAbsences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_unauthorizedAbsences_employeeLA_EmployeeComfirmId",
                        column: x => x.EmployeeComfirmId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_unauthorizedAbsences_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_courses_CourseStatusId",
                table: "courses",
                column: "CourseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_employeeLA_CommuneId",
                table: "employeeLA",
                column: "CommuneId");

            migrationBuilder.CreateIndex(
                name: "IX_employeeLA_DistrictId",
                table: "employeeLA",
                column: "DistrictId");

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
                name: "IX_employeeLA_ProvinceId",
                table: "employeeLA",
                column: "ProvinceId");

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
                name: "IX_studentCourses_CourseLAId",
                table: "studentCourses",
                column: "CourseLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentCourses_StudentLAId",
                table: "studentCourses",
                column: "StudentLAId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_CommuneId",
                table: "studentLAs",
                column: "CommuneId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_DistrictId",
                table: "studentLAs",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_GenderId",
                table: "studentLAs",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_ProvinceId",
                table: "studentLAs",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_SaleId",
                table: "studentLAs",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAs_StudentStatusId",
                table: "studentLAs",
                column: "StudentStatusId");

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
                name: "courseStatuses");

            migrationBuilder.DropTable(
                name: "employeeLA");

            migrationBuilder.DropTable(
                name: "studentStatuses");

            migrationBuilder.DropTable(
                name: "communes");

            migrationBuilder.DropTable(
                name: "districtes");

            migrationBuilder.DropTable(
                name: "employeeRoles");

            migrationBuilder.DropTable(
                name: "employeeStatuses");

            migrationBuilder.DropTable(
                name: "genders");

            migrationBuilder.DropTable(
                name: "provinces");
        }
    }
}
