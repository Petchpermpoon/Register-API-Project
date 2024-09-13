using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace register_api_project.Migrations
{
    /// <inheritdoc />
    public partial class addcolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Registers",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Registers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Registers",
                type: "datetime(6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Registers");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Registers");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Registers");
        }
    }
}
