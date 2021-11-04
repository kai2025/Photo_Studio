using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Photo_StudioAPI.Models
{
    public partial class PhotoStudioDbContext : DbContext
    {
        public PhotoStudioDbContext()
        {
        }

        public PhotoStudioDbContext(DbContextOptions<PhotoStudioDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EstadoSesion> EstadoSesions { get; set; }
        public virtual DbSet<FotosStatus> FotosStatuses { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<ReservaUsuario> ReservaUsuarios { get; set; }
        public virtual DbSet<Sesion> Sesions { get; set; }
        public virtual DbSet<SesionEntrega> SesionEntregas { get; set; }
        public virtual DbSet<TipoEntrega> TipoEntregas { get; set; }
        public virtual DbSet<TipoSesionFotografica> TipoSesionFotograficas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=KAI-PARKER\\SQLEXPRESS;Initial Catalog=AVJ_PhotoStudio;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<EstadoSesion>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PK__Estado_S__5AC2A7343C93B510");

                entity.Property(e => e.DescripciónStatus).IsUnicode(false);
            });

            modelBuilder.Entity<FotosStatus>(entity =>
            {
                entity.Property(e => e.Descripcion).IsUnicode(false);
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => new { e.IdReserva, e.UserId })
                    .HasName("PK__Reserva__C3B2553E2C25C68C");

                entity.Property(e => e.IdReserva).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdReservaNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdReserva)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reserva_Usuario1");

                entity.HasOne(d => d.TipoEntregaNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.TipoEntrega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reserva_Tipo_Entrega");

                entity.HasOne(d => d.TipoSesionNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.TipoSesion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reserva_Tipo_SesionFotografica");
            });

            modelBuilder.Entity<ReservaUsuario>(entity =>
            {
                entity.ToView("Reserva_Usuario");

                entity.Property(e => e.Cliente).IsUnicode(false);

                entity.Property(e => e.CorreoElectronico).IsUnicode(false);

                entity.Property(e => e.Detalle).IsUnicode(false);
            });

            modelBuilder.Entity<Sesion>(entity =>
            {
                entity.HasKey(e => new { e.IdSesion, e.ReservaId, e.UsuarioId })
                    .HasName("PK__Sesion__E1794C48EF2CFAB2");

                entity.Property(e => e.IdSesion).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Sesions)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sesion__Status_I__00DF2177");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Sesions)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sesion_Fotos_Status");

                entity.HasOne(d => d.Reserva)
                    .WithMany(p => p.Sesions)
                    .HasForeignKey(d => new { d.ReservaId, d.UsuarioId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sesion__308E3499");
            });

            modelBuilder.Entity<SesionEntrega>(entity =>
            {
                entity.ToView("Sesion_Entrega");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Usuario).IsUnicode(false);
            });

            modelBuilder.Entity<TipoEntrega>(entity =>
            {
                entity.Property(e => e.Descripcion).IsUnicode(false);
            });

            modelBuilder.Entity<TipoSesionFotografica>(entity =>
            {
                entity.Property(e => e.DescripciónSesion).IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Passcode).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
