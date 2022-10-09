namespace WebApplication1.Models
{
    public class Login
    {
        public int Id_Login { get; set; }
        public string? Usuario { get; set; }
        public string? Contraseña { get; set; }
        public bool Activo { get; set; }
        public DateTime Ultimo_logueo { get; set; }
        public int Id_Persona { get; set; }
    }
}
