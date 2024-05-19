using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoBD.Migrations
{
    /// <inheritdoc />
    public partial class Tablas_Nueva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Servicios_ServicioId",
                table: "Mascotas");

            migrationBuilder.DropIndex(
                name: "IX_Mascotas_ServicioId",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "ServicioId",
                table: "Mascotas");

            migrationBuilder.AddColumn<int>(
                name: "MascotaId",
                table: "Servicios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_MascotaId",
                table: "Servicios",
                column: "MascotaId",
                 unique: true);


            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Mascotas_MascotaId",
                table: "Servicios",
                column: "MascotaId",
                principalTable: "Mascotas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Mascotas_MascotaId",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_MascotaId",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "MascotaId",
                table: "Servicios");

            migrationBuilder.AddColumn<int>(
                name: "ServicioId",
                table: "Mascotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_ServicioId",
                table: "Mascotas",
                column: "ServicioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Servicios_ServicioId",
                table: "Mascotas",
                column: "ServicioId",
                principalTable: "Servicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
