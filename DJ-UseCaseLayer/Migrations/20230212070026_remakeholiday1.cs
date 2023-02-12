using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJUseCaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class remakeholiday1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CloseDay",
                table: "holidays",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CloseMonth",
                table: "holidays",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OpenDay",
                table: "holidays",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OpenMonth",
                table: "holidays",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "employeeLAHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeLAId = table.Column<int>(type: "int", nullable: true),
                    HolidayId = table.Column<int>(type: "int", nullable: true),
                    TotalDay = table.Column<int>(type: "int", nullable: true),
                    IsSalary = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeLAHolidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employeeLAHolidays_employeeLA_EmployeeLAId",
                        column: x => x.EmployeeLAId,
                        principalTable: "employeeLA",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_employeeLAHolidays_holidays_HolidayId",
                        column: x => x.HolidayId,
                        principalTable: "holidays",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "studentLAHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentLAId = table.Column<int>(type: "int", nullable: true),
                    HolidayId = table.Column<int>(type: "int", nullable: true),
                    TotalDay = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentLAHolidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentLAHolidays_holidays_HolidayId",
                        column: x => x.HolidayId,
                        principalTable: "holidays",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_studentLAHolidays_studentLAs_StudentLAId",
                        column: x => x.StudentLAId,
                        principalTable: "studentLAs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_employeeLAHolidays_EmployeeLAId",
                table: "employeeLAHolidays",
                column: "EmployeeLAId");

            migrationBuilder.CreateIndex(
                name: "IX_employeeLAHolidays_HolidayId",
                table: "employeeLAHolidays",
                column: "HolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAHolidays_HolidayId",
                table: "studentLAHolidays",
                column: "HolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_studentLAHolidays_StudentLAId",
                table: "studentLAHolidays",
                column: "StudentLAId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employeeLAHolidays");

            migrationBuilder.DropTable(
                name: "studentLAHolidays");

            migrationBuilder.DropColumn(
                name: "CloseDay",
                table: "holidays");

            migrationBuilder.DropColumn(
                name: "CloseMonth",
                table: "holidays");

            migrationBuilder.DropColumn(
                name: "OpenDay",
                table: "holidays");

            migrationBuilder.DropColumn(
                name: "OpenMonth",
                table: "holidays");
        }
    }
}
