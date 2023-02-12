using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJUseCaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class remakeattendance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UnauthorizedAbsencesName",
                table: "attendance",
                newName: "UnactiveReason");

            migrationBuilder.AddColumn<int>(
                name: "LateMinuteTotal",
                table: "studentLAs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ActiveRealTime",
                table: "attendance",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsLate",
                table: "attendance",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LateMinuteTotal",
                table: "attendance",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LateMinuteTotal",
                table: "studentLAs");

            migrationBuilder.DropColumn(
                name: "ActiveRealTime",
                table: "attendance");

            migrationBuilder.DropColumn(
                name: "IsLate",
                table: "attendance");

            migrationBuilder.DropColumn(
                name: "LateMinuteTotal",
                table: "attendance");

            migrationBuilder.RenameColumn(
                name: "UnactiveReason",
                table: "attendance",
                newName: "UnauthorizedAbsencesName");
        }
    }
}
