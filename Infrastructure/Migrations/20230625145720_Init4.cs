using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentEmployees_Employees_EmployeeId1",
                table: "DepartmentEmployees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentEmployees",
                table: "DepartmentEmployees");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentEmployees_EmployeeId1",
                table: "DepartmentEmployees");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "DepartmentEmployees");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "DepartmentEmployees",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentEmployees",
                table: "DepartmentEmployees",
                columns: new[] { "EmployeeId", "DepartmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentEmployees_Employees_EmployeeId",
                table: "DepartmentEmployees",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentEmployees_Employees_EmployeeId",
                table: "DepartmentEmployees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentEmployees",
                table: "DepartmentEmployees");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "DepartmentEmployees",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "DepartmentEmployees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentEmployees",
                table: "DepartmentEmployees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentEmployees_EmployeeId1",
                table: "DepartmentEmployees",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentEmployees_Employees_EmployeeId1",
                table: "DepartmentEmployees",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
