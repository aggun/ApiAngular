using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class mig_new_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Personals");

            migrationBuilder.AddColumn<string>(
                name: "Birthday",
                table: "Personals",
                type: "nvarchar(20)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Personals");

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Personals",
                type: "nvarchar(3)",
                nullable: true);
        }
    }
}
