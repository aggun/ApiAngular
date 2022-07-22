using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class mig_for_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personals",
                columns: table => new
                {
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SecurityCode = table.Column<string>(type: "nvarchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personals", x => x.PersonalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personals");
        }
    }
}
