using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentManagers_Employees_EmployeeId1",
                table: "DepartmentManagers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentManagers",
                table: "DepartmentManagers");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentManagers_EmployeeId1",
                table: "DepartmentManagers");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "DepartmentManagers");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "DepartmentManagers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentManagers",
                table: "DepartmentManagers",
                columns: new[] { "EmployeeId", "DepartmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentManagers_Employees_EmployeeId",
                table: "DepartmentManagers",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentManagers_Employees_EmployeeId",
                table: "DepartmentManagers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentManagers",
                table: "DepartmentManagers");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "DepartmentManagers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "DepartmentManagers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentManagers",
                table: "DepartmentManagers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentManagers_EmployeeId1",
                table: "DepartmentManagers",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentManagers_Employees_EmployeeId1",
                table: "DepartmentManagers",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
