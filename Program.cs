using entity_first_project;
using entity_first_project.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddNpgsql<PrestamosContext>(builder.Configuration.GetConnectionString("PrestamosDb"));
var app = builder.Build();

app.MapGet("/", () => TipoPrestamo.Consumo);

app.MapGet("/api/prestamos", async ([FromServices] PrestamosContext dbContext) =>
{
  return Results.Ok(dbContext.Prestamos);
});

app.MapPost("/api/prestamos", async ([FromServices] PrestamosContext dbContext, [FromBody] Prestamo prestamo) =>
{
  prestamo.FechaCreacion = DateTime.UtcNow;
  await dbContext.AddAsync(prestamo);
  await dbContext.SaveChangesAsync();

  return Results.Ok("Prestamo posted");
});

app.MapGet("/api/prestamos/{id}", async ([FromServices] PrestamosContext dbContext, [FromRoute] long id) =>
{
  var prestamoPorUsuario = dbContext.Prestamos.FirstOrDefault(p => p.EmpleadoId == id);
  if (prestamoPorUsuario == null)
  {
    return Results.NotFound("User not Found");
  }
  return Results.Ok(prestamoPorUsuario);
});

app.MapDelete("/api/prestamos/{id}", async ([FromServices] PrestamosContext dbContext, [FromRoute] long id) =>
{
  var prestamoItem = dbContext.Prestamos.Find(id);

  if (prestamoItem == null)
  {
    return Results.NotFound("Task not found");
  }

  dbContext.Remove(prestamoItem);
  await dbContext.SaveChangesAsync();
  return Results.Ok("Succesfully deleted");


});

app.Run();
