using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hackaton.App.Persistencia.Migrations
{
    public partial class PuebraInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Migrantes",
                columns: table => new
                {
                    MigranteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoId = table.Column<int>(type: "int", nullable: false),
                    identificacion = table.Column<long>(type: "bigint", nullable: false),
                    paisOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    correoE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<long>(type: "bigint", nullable: false),
                    direcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sitLaboral = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Migrantes", x => x.MigranteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Migrantes");
        }
    }
}
