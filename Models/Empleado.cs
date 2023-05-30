
namespace entity_first_project.Models
{
  public class Empleado
  {
    //[Key]
    public Guid EmpleadoId { get; set; }

    //[Required]
    //[MaxLength(20)]
    public string Nombre { get; set; }

    //[Required]
    //[MaxLength(20)]
    public string Apellido { get; set; }

    //[Required]
    //[MaxLength(10)]
    //[MinLength(10)]
    public long Identificacion { get; set; }

    //[Required]
    public string Puesto { get; set; }
  }
}