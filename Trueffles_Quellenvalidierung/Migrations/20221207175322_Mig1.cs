using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruefflesQuellenvalidierung.Migrations
{
    /// <inheritdoc />
    public partial class Mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Todo",
                table: "Todo");

            migrationBuilder.RenameTable(
                name: "Todo",
                newName: "Quellen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quellen",
                table: "Quellen",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Quellen",
                table: "Quellen");

            migrationBuilder.RenameTable(
                name: "Quellen",
                newName: "Todo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Todo",
                table: "Todo",
                column: "ID");
        }
    }
}
