using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DJUseCaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class latest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnactiveTotal",
                table: "studentLAs",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnactiveTotal",
                table: "studentLAs");
        }
    }
}
