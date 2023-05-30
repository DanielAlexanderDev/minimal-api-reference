
namespace entity_first_project.Models
{
  public class Prestamo
  {
    //[Key]
    public long PrestamoId { get; set; }

    public int ValorPrestamo { get; set; }

    public double ValorCuotaMensual { get; set; }

    //[ForeignKey("EmpleadoId")]
    public long EmpleadoId { get; set; }

    public int NumeroCuotas { get; set; }

    public DateTime FechaCreacion { get; set; }


  }
  public enum TipoPrestamo
  {
    Educacion = 6,
    Consumo = 8,
    Calamidad = 4
  }
}