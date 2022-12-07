using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruefflesQuellenvalidierung.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Updatedatum",
                table: "Quellen");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Updatedatum",
                table: "Quellen",
                type: "TEXT",
                nullable: true);
        }
    }
}
