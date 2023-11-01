using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "location",
                table: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "location",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
