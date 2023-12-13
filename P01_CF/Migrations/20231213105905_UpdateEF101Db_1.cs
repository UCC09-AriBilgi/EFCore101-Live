using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P01_CF.Migrations
{
    public partial class UpdateEF101Db_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SLastName",
                table: "Students",
                type: "NVarchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVarchar(20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SLastName",
                table: "Students",
                type: "NVarchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVarchar(30)");
        }
    }
}
