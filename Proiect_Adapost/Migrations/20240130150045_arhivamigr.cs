using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Adapost.Migrations
{
    /// <inheritdoc />
    public partial class arhivamigr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descriere",
                table: "Conditii");

            migrationBuilder.CreateTable(
                name: "Arhiva",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Categorie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descriere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arhiva", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Control",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConditieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArhivaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Control", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Control_Arhiva_ArhivaId",
                        column: x => x.ArhivaId,
                        principalTable: "Arhiva",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Control_Conditii_ConditieId",
                        column: x => x.ConditieId,
                        principalTable: "Conditii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Control_ArhivaId",
                table: "Control",
                column: "ArhivaId");

            migrationBuilder.CreateIndex(
                name: "IX_Control_ConditieId",
                table: "Control",
                column: "ConditieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Control");

            migrationBuilder.DropTable(
                name: "Arhiva");

            migrationBuilder.AddColumn<string>(
                name: "Descriere",
                table: "Conditii",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
