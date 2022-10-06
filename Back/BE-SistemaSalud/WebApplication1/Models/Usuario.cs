namespace WebApplication1.Models
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Contraseña { get; set; }
        public DateTime Fecha_De_Creacion { get; set; }
        public bool Activo { get; set; }
    }
}
