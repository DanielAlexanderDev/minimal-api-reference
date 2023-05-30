using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entity_first_project.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataPrestamo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Prestamo",
                columns: new[] { "PrestamoId", "EmpleadoId", "FechaCreacion", "NumeroCuotas", "ValorCuotaMensual", "ValorPrestamo" },
                values: new object[] { 1L, 1751631530L, new DateTime(2023, 5, 30, 2, 26, 44, 18, DateTimeKind.Utc).AddTicks(4170), 3, 326.25, 1500 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prestamo",
                keyColumn: "PrestamoId",
                keyValue: 1L);
        }
    }
}
