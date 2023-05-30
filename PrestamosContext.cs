using entity_first_project.Models;
using Microsoft.EntityFrameworkCore;

namespace entity_first_project
{
  // Db Context represents the place where all the fields interact
  // themselves to become a db entity or a table, everything inside the context
  // Writing and readign of db queries
  public class PrestamosContext : DbContext
  {
    public DbSet<Empleado> Empleados { get; set; }

    // DbSet represents all entities collection or db collection that are available to query 
    public DbSet<Prestamo> Prestamos { get; set; }

    public PrestamosContext(DbContextOptions<PrestamosContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      List<Empleado> empleadoInit = new List<Empleado>();
      empleadoInit.Add(new Empleado() { EmpleadoId = Guid.Parse("7fe94fa9-9416-42a4-8e08-948a26d87266"), Nombre = "Daniel", Apellido = "LLumiquinga", Identificacion = 1751631530, Puesto = "Desarrollador" });
      modelBuilder.Entity<Empleado>(empleado =>
      {
        empleado.ToTable("Empleado");
        empleado.HasKey(e => e.EmpleadoId);
        empleado.Property(e => e.Nombre).IsRequired().HasMaxLength(20);
        empleado.Property(e => e.Apellido).IsRequired().HasMaxLength(20);
        empleado.Property(e => e.Identificacion).IsRequired().HasMaxLength(10);
        empleado.Property(e => e.Puesto).IsRequired().HasMaxLength(30);
        empleado.HasData(empleadoInit);
      });

      List<Prestamo> prestamoInit = new List<Prestamo>();
      prestamoInit.Add(new Prestamo() { PrestamoId = 1, ValorPrestamo = 1500, ValorCuotaMensual = 326.25, EmpleadoId = 1751631530, NumeroCuotas = 3, FechaCreacion = DateTime.UtcNow });

      modelBuilder.Entity<Prestamo>(prestamo =>
      {
        prestamo.ToTable("Prestamo");
        prestamo.HasKey(p => p.PrestamoId);
        prestamo.Property(p => p.ValorPrestamo).IsRequired();
        prestamo.Property(p => p.ValorCuotaMensual).IsRequired();
        prestamo.Property(p => p.EmpleadoId);
        prestamo.Property(p => p.NumeroCuotas).IsRequired();
        prestamo.Property(p => p.FechaCreacion);
        prestamo.HasData(prestamoInit);

      });
    }
  }
}