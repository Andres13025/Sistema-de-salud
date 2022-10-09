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
        public virtual DbSet<TiposCondiciones> TiposCondiciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("LOGIN");
                entity.Property(e => e.Id_Login).HasColumnName("Id_Login");
                entity.Property(e => e.Usuario).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Contraseña).HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.Ultimo_logueo).IsUnicode(false);
                entity.Property(e => e.Activo).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
