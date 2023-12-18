using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P01_CF.Migrations
{
    public partial class UpdateEF101Db_Person_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PEMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PPostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PGender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
