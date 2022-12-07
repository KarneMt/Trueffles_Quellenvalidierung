using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruefflesQuellenvalidierung.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    URL = table.Column<string>(type: "TEXT", nullable: false),
                    Check = table.Column<string>(type: "TEXT", nullable: false),
                    Createdatum = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Updatedatum = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todo");
        }
    }
}
