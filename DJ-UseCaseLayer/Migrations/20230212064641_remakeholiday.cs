using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJUseCaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class remakeholiday : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_holidays_employeeLA_EmployeeComfirmId",
                table: "holidays");

            migrationBuilder.DropForeignKey(
                name: "FK_holidays_studentLAs_StudentLAId",
                table: "holidays");

            migrationBuilder.DropIndex(
                name: "IX_holidays_StudentLAId",
                table: "holidays");

            migrationBuilder.DropColumn(
                name: "CloseTime",
                table: "holidays");

            migrationBuilder.RenameColumn(
                name: "StudentLAId",
                table: "holidays",
                newName: "TotalDay");

            migrationBuilder.RenameColumn(
                name: "OpenTime",
                table: "holidays",
                newName: "CreateDateTime");

            migrationBuilder.RenameColumn(
                name: "EmployeeComfirmId",
                table: "holidays",
                newName: "HolidayStatusId");

            migrationBuilder.RenameColumn(
                name: "DateDiff",
                table: "holidays",
                newName: "EmployeeLACreateId");

            migrationBuilder.RenameIndex(
                name: "IX_holidays_EmployeeComfirmId",
                table: "holidays",
                newName: "IX_holidays_HolidayStatusId");

            migrationBuilder.AddColumn<string>(
                name: "HolidayDetail",
                table: "holidays",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "holidayStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HolidayCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HolidayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_holidayStatuses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_holidays_EmployeeLACreateId",
                table: "holidays",
                column: "EmployeeLACreateId");

            migrationBuilder.AddForeignKey(
                name: "FK_holidays_employeeLA_EmployeeLACreateId",
                table: "holidays",
                column: "EmployeeLACreateId",
                principalTable: "employeeLA",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_holidays_holidayStatuses_HolidayStatusId",
                table: "holidays",
                column: "HolidayStatusId",
                principalTable: "holidayStatuses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_holidays_employeeLA_EmployeeLACreateId",
                table: "holidays");

            migrationBuilder.DropForeignKey(
                name: "FK_holidays_holidayStatuses_HolidayStatusId",
                table: "holidays");

            migrationBuilder.DropTable(
                name: "holidayStatuses");

            migrationBuilder.DropIndex(
                name: "IX_holidays_EmployeeLACreateId",
                table: "holidays");

            migrationBuilder.DropColumn(
                name: "HolidayDetail",
                table: "holidays");

            migrationBuilder.RenameColumn(
                name: "TotalDay",
                table: "holidays",
                newName: "StudentLAId");

            migrationBuilder.RenameColumn(
                name: "HolidayStatusId",
                table: "holidays",
                newName: "EmployeeComfirmId");

            migrationBuilder.RenameColumn(
                name: "EmployeeLACreateId",
                table: "holidays",
                newName: "DateDiff");

            migrationBuilder.RenameColumn(
                name: "CreateDateTime",
                table: "holidays",
                newName: "OpenTime");

            migrationBuilder.RenameIndex(
                name: "IX_holidays_HolidayStatusId",
                table: "holidays",
                newName: "IX_holidays_EmployeeComfirmId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CloseTime",
                table: "holidays",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_holidays_StudentLAId",
                table: "holidays",
                column: "StudentLAId");

            migrationBuilder.AddForeignKey(
                name: "FK_holidays_employeeLA_EmployeeComfirmId",
                table: "holidays",
                column: "EmployeeComfirmId",
                principalTable: "employeeLA",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_holidays_studentLAs_StudentLAId",
                table: "holidays",
                column: "StudentLAId",
                principalTable: "studentLAs",
                principalColumn: "Id");
        }
    }
}
