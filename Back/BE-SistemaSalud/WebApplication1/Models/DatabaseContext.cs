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

        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<TiposCondiciones> TiposCondiciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("Usuario");
                entity.Property(e => e.Id_Usuario).HasColumnName("Id_usuario");
                entity.Property(e => e.Nombre).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Correo).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Contraseña).HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.Fecha_De_Creacion).IsUnicode(false);
                entity.Property(e => e.Activo).IsUnicode(false);
            });

            modelBuilder.Entity<TiposCondiciones>(entity =>
            {
                entity.ToTable("TiposCondiciones");
                entity.Property(e => e.Id_Condicion_De_Salud).HasColumnName("Id_Condicion_De_Salud");
                entity.Property(e => e.Descripcion).HasMaxLength(150).IsUnicode(false);
                entity.Property(e => e.Fecha_Emision).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
