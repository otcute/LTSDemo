using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJWebDesignCore.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentStatusId",
                table: "students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeStatusId",
                table: "employeeLA",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_StudentStatusId",
                table: "students",
                column: "StudentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_employeeLA_EmployeeStatusId",
                table: "employeeLA",
                column: "EmployeeStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_employeeLA_employeeStatuses_EmployeeStatusId",
                table: "employeeLA",
                column: "EmployeeStatusId",
                principalTable: "employeeStatuses",
                principalColumn: "EmployeeStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_studentStatuses_StudentStatusId",
                table: "students",
                column: "StudentStatusId",
                principalTable: "studentStatuses",
                principalColumn: "StudentStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employeeLA_employeeStatuses_EmployeeStatusId",
                table: "employeeLA");

            migrationBuilder.DropForeignKey(
                name: "FK_students_studentStatuses_StudentStatusId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_StudentStatusId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_employeeLA_EmployeeStatusId",
                table: "employeeLA");

            migrationBuilder.DropColumn(
                name: "StudentStatusId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "EmployeeStatusId",
                table: "employeeLA");
        }
    }
}
