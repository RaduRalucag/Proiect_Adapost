using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Adapost.Migrations
{
    /// <inheritdoc />
    public partial class orasmigr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OrasId",
                table: "Adaposts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Orase",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orase", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adaposts_OrasId",
                table: "Adaposts",
                column: "OrasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adaposts_Orase_OrasId",
                table: "Adaposts",
                column: "OrasId",
                principalTable: "Orase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adaposts_Orase_OrasId",
                table: "Adaposts");

            migrationBuilder.DropTable(
                name: "Orase");

            migrationBuilder.DropIndex(
                name: "IX_Adaposts_OrasId",
                table: "Adaposts");

            migrationBuilder.DropColumn(
                name: "OrasId",
                table: "Adaposts");
        }
    }
}
