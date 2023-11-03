using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeApiusingentity.Migrations
{
    /// <inheritdoc />
    public partial class AddedDesignation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Designation_DesignationId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Designation",
                table: "Designation");

            migrationBuilder.RenameTable(
                name: "Designation",
                newName: "Designations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Designations",
                table: "Designations",
                column: "DesignationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Designations_DesignationId",
                table: "Employees",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "DesignationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Designations_DesignationId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Designations",
                table: "Designations");

            migrationBuilder.RenameTable(
                name: "Designations",
                newName: "Designation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Designation",
                table: "Designation",
                column: "DesignationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Designation_DesignationId",
                table: "Employees",
                column: "DesignationId",
                principalTable: "Designation",
                principalColumn: "DesignationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
