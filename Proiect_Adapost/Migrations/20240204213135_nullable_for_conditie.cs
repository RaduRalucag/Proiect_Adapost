﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Adapost.Migrations
{
    /// <inheritdoc />
    public partial class nullable_for_conditie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conditii_Adaposts_AdapostId",
                table: "Conditii");

            migrationBuilder.DropIndex(
                name: "IX_Conditii_AdapostId",
                table: "Conditii");

            migrationBuilder.AlterColumn<Guid>(
                name: "AdapostId",
                table: "Conditii",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Conditii_AdapostId",
                table: "Conditii",
                column: "AdapostId",
                unique: true,
                filter: "[AdapostId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Conditii_Adaposts_AdapostId",
                table: "Conditii",
                column: "AdapostId",
                principalTable: "Adaposts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conditii_Adaposts_AdapostId",
                table: "Conditii");

            migrationBuilder.DropIndex(
                name: "IX_Conditii_AdapostId",
                table: "Conditii");

            migrationBuilder.AlterColumn<Guid>(
                name: "AdapostId",
                table: "Conditii",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conditii_AdapostId",
                table: "Conditii",
                column: "AdapostId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Conditii_Adaposts_AdapostId",
                table: "Conditii",
                column: "AdapostId",
                principalTable: "Adaposts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
