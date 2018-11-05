using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proyectomulti.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaña",
                columns: table => new
                {
                    CampañaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    informacion = table.Column<string>(nullable: false),
                    distrito = table.Column<string>(nullable: false),
                    CantidadPersonas = table.Column<int>(nullable: false),
                    distrito_pro = table.Column<string>(nullable: true),
                    edad_min = table.Column<int>(nullable: false),
                    implementos = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaña", x => x.CampañaId);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Edad = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Contraseña = table.Column<string>(nullable: false),
                    celular = table.Column<int>(nullable: false),
                    distrito = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "camp_usuario",
                columns: table => new
                {
                    CampañaId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    montoDonacion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_camp_usuario", x => new { x.UsuarioId, x.CampañaId });
                    table.ForeignKey(
                        name: "FK_camp_usuario_Campaña_CampañaId",
                        column: x => x.CampañaId,
                        principalTable: "Campaña",
                        principalColumn: "CampañaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_camp_usuario_usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_camp_usuario_CampañaId",
                table: "camp_usuario",
                column: "CampañaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "camp_usuario");

            migrationBuilder.DropTable(
                name: "Campaña");

            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
