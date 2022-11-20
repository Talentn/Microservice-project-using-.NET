using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalP.Services.ClasseAPI.Migrations
{
    public partial class seedEtudiants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "EtudiantId", "Classename", "EtudiantName", "age" },
                values: new object[] { 1, "GLSI-A", "Ala Ghabi", 24 });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "EtudiantId", "Classename", "EtudiantName", "age" },
                values: new object[] { 2, "GLSI-A", "Eya Ben Hamza", 24 });

            migrationBuilder.InsertData(
                table: "Etudiants",
                columns: new[] { "EtudiantId", "Classename", "EtudiantName", "age" },
                values: new object[] { 3, "GLSI-A", "Raja ben Salem", 24 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Etudiants",
                keyColumn: "EtudiantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Etudiants",
                keyColumn: "EtudiantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Etudiants",
                keyColumn: "EtudiantId",
                keyValue: 3);
        }
    }
}
