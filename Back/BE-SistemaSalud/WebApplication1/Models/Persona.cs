using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Persona
    {
        [Column("Id_Persona")]
        [Key]
        public int Id_Persona { get; set; }
        [Column("Primer_Nombre")]
        public string? Primer_Nombre { get; set; }
        [Column("Segundo_Nombre")]
        public string? Segundo_Nombre { get; set; }
        [Column("Primer_Apellido")]
        public string? Primer_Apellido { get; set; }
        [Column("Segundo_Apellido")]
        public string? Segundo_Apellido { get; set; }
        [Column("Identificacion")]
        public string? Identificacion { get; set; }
        [Column("Id_Tipo_identificacion")]
        public int Id_Tipo_identificacion { get; set; }
        [Column("Fecha_nacimiento")]
        public DateTime? Fecha_nacimiento { get; set; }
        [Column("Id_Genero")]
        public int Id_Genero { get; set; }
        [Column("Correo")]
        public string? Correo { get; set; }
        [Column("Parentesco")]
        public string? Parentesco { get; set; }
    }
}
