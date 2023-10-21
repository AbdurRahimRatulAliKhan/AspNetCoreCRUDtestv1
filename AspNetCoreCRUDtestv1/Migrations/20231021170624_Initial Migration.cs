using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCoreCRUDtestv1.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeePhoneId = table.Column<int>(type: "int", nullable: true),
                    EmployeePhoneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeePhoneDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
