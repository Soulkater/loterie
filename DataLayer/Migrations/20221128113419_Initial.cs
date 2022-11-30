using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tirage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResultatTirage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateHeureTirage = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CagnotteTirage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tirage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partie",
                columns: table => new
                {
                    Guid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrillePartie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TirageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partie", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Partie_Tirage_TirageId",
                        column: x => x.TirageId,
                        principalTable: "Tirage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Partie_TirageId",
                table: "Partie",
                column: "TirageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partie");

            migrationBuilder.DropTable(
                name: "Tirage");
        }
    }
}
