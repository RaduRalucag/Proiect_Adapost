using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Adapost.Migrations
{
    /// <inheritdoc />
    public partial class addanimalidincarnet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AnimalId",
                table: "Carnete_sanatate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Carnete_sanatate_AnimalId",
                table: "Carnete_sanatate",
                column: "AnimalId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carnete_sanatate_Animale_AnimalId",
                table: "Carnete_sanatate",
                column: "AnimalId",
                principalTable: "Animale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carnete_sanatate_Animale_AnimalId",
                table: "Carnete_sanatate");

            migrationBuilder.DropIndex(
                name: "IX_Carnete_sanatate_AnimalId",
                table: "Carnete_sanatate");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Carnete_sanatate");
        }
    }
}
