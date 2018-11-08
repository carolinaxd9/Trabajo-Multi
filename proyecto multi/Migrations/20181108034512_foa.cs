using Microsoft.EntityFrameworkCore.Migrations;

namespace proyectomulti.Migrations
{
    public partial class foa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "edad_min",
                table: "Campaña");

            migrationBuilder.RenameColumn(
                name: "distrito_pro",
                table: "Campaña",
                newName: "foto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "foto",
                table: "Campaña",
                newName: "distrito_pro");

            migrationBuilder.AddColumn<int>(
                name: "edad_min",
                table: "Campaña",
                nullable: false,
                defaultValue: 0);
        }
    }
}
