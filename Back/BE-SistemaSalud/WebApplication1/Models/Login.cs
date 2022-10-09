using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Login
    {
        [Column("Id_Login")]
        [Key]
        public int Id_Login { get; set; }
        [Column("Usuario")]
        public string? Usuario { get; set; }
        [Column("Contraseña")]
        public string? Contraseña { get; set; }
        [Column("Activo")]
        public bool Activo { get; set; }
        [Column("Ultimo_logueo")]
        public DateTime Ultimo_logueo { get; set; }
        [Column("Id_Persona")]
        public int Id_Persona { get; set; }
    }
}
