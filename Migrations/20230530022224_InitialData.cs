using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entity_first_project.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Empleado",
                columns: new[] { "EmpleadoId", "Apellido", "Identificacion", "Nombre", "Puesto" },
                values: new object[] { new Guid("7fe94fa9-9416-42a4-8e08-948a26d87266"), "LLumiquinga", 1751631530L, "Daniel", "Desarrollador" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Empleado",
                keyColumn: "EmpleadoId",
                keyValue: new Guid("7fe94fa9-9416-42a4-8e08-948a26d87266"));
        }
    }
}
