using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Login> Usuario { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("LOGIN");
                entity.Property(e => e.Id_Login).HasColumnName("Id_Login");
                entity.Property(e => e.Usuario).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Contraseña).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Ultimo_logueo).IsUnicode(false);
                entity.Property(e => e.Activo).IsUnicode(false);
                entity.Property(e => e.Id_Persona).IsUnicode(false);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("PERSONA");
                entity.Property(e => e.Id_Persona).HasColumnName("Id_Persona");
                entity.Property(e => e.Primer_Nombre).HasMaxLength(20).IsUnicode(false);
                entity.Property(e => e.Segundo_Nombre).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Primer_Nombre).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Segundo_Apellido).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Identificacion).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Id_Tipo_identificacion).IsUnicode(false);
                entity.Property(e => e.Fecha_nacimiento).IsUnicode(false);
                entity.Property(e => e.Id_Genero).IsUnicode(false);
                entity.Property(e => e.Correo).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Parentesco).HasMaxLength(50).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
