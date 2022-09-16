using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fakultet",
                columns: table => new
                {
                    FakultetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivFakulteta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakultet", x => x.FakultetId);
                });

            migrationBuilder.CreateTable(
                name: "Mesto",
                columns: table => new
                {
                    MestoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivMesta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesto", x => x.MestoId);
                });

            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    OsobaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.OsobaId);
                });

            migrationBuilder.CreateTable(
                name: "Takmicenje",
                columns: table => new
                {
                    TakmicenjeId = table.Column<int>(type: "int", nullable: false),
                    Tema = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumOdrzavanja = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takmicenje", x => x.TakmicenjeId);
                });

            migrationBuilder.CreateTable(
                name: "Tim",
                columns: table => new
                {
                    TimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivTima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FakultetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tim", x => x.TimId);
                    table.ForeignKey(
                        name: "FK_Tim_Fakultet_FakultetId",
                        column: x => x.FakultetId,
                        principalTable: "Fakultet",
                        principalColumn: "FakultetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    OsobaId = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.OsobaId);
                    table.ForeignKey(
                        name: "FK_Administrator_Osoba_OsobaId",
                        column: x => x.OsobaId,
                        principalTable: "Osoba",
                        principalColumn: "OsobaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ucesce",
                columns: table => new
                {
                    TimId = table.Column<int>(type: "int", nullable: false),
                    TakmicenjeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ucesce", x => new { x.TimId, x.TakmicenjeId });
                    table.ForeignKey(
                        name: "FK_Ucesce_Takmicenje_TakmicenjeId",
                        column: x => x.TakmicenjeId,
                        principalTable: "Takmicenje",
                        principalColumn: "TakmicenjeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ucesce_Tim_TimId",
                        column: x => x.TimId,
                        principalTable: "Tim",
                        principalColumn: "TimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ucesnik",
                columns: table => new
                {
                    OsobaId = table.Column<int>(type: "int", nullable: false),
                    JMBG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GodinaStudija = table.Column<int>(type: "int", nullable: false),
                    Kontakt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MestoId = table.Column<int>(type: "int", nullable: false),
                    TimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ucesnik", x => x.OsobaId);
                    table.ForeignKey(
                        name: "FK_Ucesnik_Mesto_MestoId",
                        column: x => x.MestoId,
                        principalTable: "Mesto",
                        principalColumn: "MestoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ucesnik_Osoba_OsobaId",
                        column: x => x.OsobaId,
                        principalTable: "Osoba",
                        principalColumn: "OsobaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ucesnik_Tim_TimId",
                        column: x => x.TimId,
                        principalTable: "Tim",
                        principalColumn: "TimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tim_FakultetId",
                table: "Tim",
                column: "FakultetId");

            migrationBuilder.CreateIndex(
                name: "IX_Ucesce_TakmicenjeId",
                table: "Ucesce",
                column: "TakmicenjeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ucesnik_MestoId",
                table: "Ucesnik",
                column: "MestoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ucesnik_TimId",
                table: "Ucesnik",
                column: "TimId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrator");

            migrationBuilder.DropTable(
                name: "Ucesce");

            migrationBuilder.DropTable(
                name: "Ucesnik");

            migrationBuilder.DropTable(
                name: "Takmicenje");

            migrationBuilder.DropTable(
                name: "Mesto");

            migrationBuilder.DropTable(
                name: "Osoba");

            migrationBuilder.DropTable(
                name: "Tim");

            migrationBuilder.DropTable(
                name: "Fakultet");
        }
    }
}
