using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class ajoutnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partie_Tirage_TirageId",
                table: "Partie");

            migrationBuilder.AlterColumn<int>(
                name: "TirageId",
                table: "Partie",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Partie_Tirage_TirageId",
                table: "Partie",
                column: "TirageId",
                principalTable: "Tirage",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partie_Tirage_TirageId",
                table: "Partie");

            migrationBuilder.AlterColumn<int>(
                name: "TirageId",
                table: "Partie",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Partie_Tirage_TirageId",
                table: "Partie",
                column: "TirageId",
                principalTable: "Tirage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
