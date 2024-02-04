using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Adapost.Migrations
{
    /// <inheritdoc />
    public partial class addallmigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Clienti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clienti", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Adaposts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Locatie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConditieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adaposts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adaposts_Orase_OrasId",
                        column: x => x.OrasId,
                        principalTable: "Orase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rasa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Culoare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdapostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animale_Adaposts_AdapostId",
                        column: x => x.AdapostId,
                        principalTable: "Adaposts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Conditii",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Denumire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gravitate = table.Column<int>(type: "int", nullable: false),
                    AdapostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditii", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conditii_Adaposts_AdapostId",
                        column: x => x.AdapostId,
                        principalTable: "Adaposts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimaleClienti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumarAdoptii = table.Column<int>(type: "int", nullable: false),
                    DataAdoptie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimaleClienti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimaleClienti_Animale_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimaleClienti_Clienti_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clienti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carnete_sanatate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Vaccin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Varsta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carnete_sanatate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carnete_sanatate_Animale_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Adaposts_Nume",
                table: "Adaposts",
                column: "Nume",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adaposts_OrasId",
                table: "Adaposts",
                column: "OrasId");

            migrationBuilder.CreateIndex(
                name: "IX_Animale_AdapostId",
                table: "Animale",
                column: "AdapostId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimaleClienti_AnimalId",
                table: "AnimaleClienti",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimaleClienti_ClientId",
                table: "AnimaleClienti",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Carnete_sanatate_AnimalId",
                table: "Carnete_sanatate",
                column: "AnimalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conditii_AdapostId",
                table: "Conditii",
                column: "AdapostId",
                unique: true);

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
                name: "AnimaleClienti");

            migrationBuilder.DropTable(
                name: "Carnete_sanatate");

            migrationBuilder.DropTable(
                name: "Control");

            migrationBuilder.DropTable(
                name: "Clienti");

            migrationBuilder.DropTable(
                name: "Animale");

            migrationBuilder.DropTable(
                name: "Arhiva");

            migrationBuilder.DropTable(
                name: "Conditii");

            migrationBuilder.DropTable(
                name: "Adaposts");

            migrationBuilder.DropTable(
                name: "Orase");
        }
    }
}
