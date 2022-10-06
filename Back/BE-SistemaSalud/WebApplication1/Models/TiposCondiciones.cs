using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class TiposCondiciones
    {
        [Key]
        public int Id_Condicion_De_Salud { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? Fecha_Emision { get; set; }
    }
}
