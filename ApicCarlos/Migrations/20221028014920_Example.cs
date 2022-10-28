﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ApicCarlos.Migrations
{
    public partial class Example : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "generos",
                columns: table => new
                {
                    PkGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_generos", x => x.PkGenero);
                });

            migrationBuilder.CreateTable(
                name: "personajes",
                columns: table => new
                {
                    PkPersonaje = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fkgenero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personajes", x => x.PkPersonaje);
                    table.ForeignKey(
                        name: "FK_personajes_generos_Fkgenero",
                        column: x => x.Fkgenero,
                        principalTable: "generos",
                        principalColumn: "PkGenero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personajes_Fkgenero",
                table: "personajes",
                column: "Fkgenero");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personajes");

            migrationBuilder.DropTable(
                name: "generos");
        }
    }
}
