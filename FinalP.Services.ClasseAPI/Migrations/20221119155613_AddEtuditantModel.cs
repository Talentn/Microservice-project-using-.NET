using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalP.Services.ClasseAPI.Migrations
{
    public partial class AddEtuditantModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Etudiants",
                columns: table => new
                {
                    EtudiantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EtudiantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Classename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etudiants", x => x.EtudiantId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Etudiants");
        }
    }
}
