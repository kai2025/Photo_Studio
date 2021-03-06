// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Photo_StudioAPI.Models;

namespace Photo_StudioAPI.Migrations
{
    [DbContext(typeof(PhotoStudioDbContext))]
    [Migration("20211110011512_DBCREATION")]
    partial class DBCREATION
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Photo_StudioAPI.Models.EstadoSesion", b =>
                {
                    b.Property<int>("IdStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Status")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripciónStatus")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Descripción_Status");

                    b.HasKey("IdStatus")
                        .HasName("PK__Estado_S__5AC2A7343C93B510");

                    b.ToTable("Estado_Sesion");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.FotosStatus", b =>
                {
                    b.Property<int>("IdStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Status")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdStatus");

                    b.ToTable("Fotos_Status");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.Reserva", b =>
                {
                    b.Property<int>("IdReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Reserva");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime")
                        .HasColumnName("Fecha_Hora");

                    b.Property<int>("RevStatus")
                        .HasColumnType("int")
                        .HasColumnName("Rev_status");

                    b.Property<int>("TipoEntrega")
                        .HasColumnType("int")
                        .HasColumnName("Tipo_Entrega");

                    b.Property<int>("TipoSesion")
                        .HasColumnType("int")
                        .HasColumnName("Tipo_Sesion");

                    b.HasKey("IdReserva", "UserId")
                        .HasName("PK__Reserva__C3B2553E2C25C68C");

                    b.HasIndex("TipoEntrega");

                    b.HasIndex("TipoSesion");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.ReservaUsuario", b =>
                {
                    b.Property<string>("Cliente")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Correo Electronico");

                    b.Property<decimal>("Costo")
                        .HasColumnType("numeric(6,2)");

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<int>("NoUsuario")
                        .HasColumnType("int")
                        .HasColumnName("No. Usuario");

                    b.Property<int>("RevervaNo")
                        .HasColumnType("int")
                        .HasColumnName("Reverva no.");

                    b.ToView("Reserva_Usuario");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.Sesion", b =>
                {
                    b.Property<int>("IdSesion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Sesion")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReservaId")
                        .HasColumnType("int")
                        .HasColumnName("Reserva_ID");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("Usuario_ID");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("Status_ID");

                    b.HasKey("IdSesion", "ReservaId", "UsuarioId")
                        .HasName("PK__Sesion__E1794C48EF2CFAB2");

                    b.HasIndex("StatusId");

                    b.HasIndex("ReservaId", "UsuarioId");

                    b.ToTable("Sesion");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.SesionEntrega", b =>
                {
                    b.Property<int>("EntregaDeFotos")
                        .HasColumnType("int")
                        .HasColumnName("Entrega de fotos");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<int>("ReservaNo")
                        .HasColumnType("int")
                        .HasColumnName("Reserva No.");

                    b.Property<int>("SesionNo")
                        .HasColumnType("int")
                        .HasColumnName("Sesion No.");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.ToView("Sesion_Entrega");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.TipoEntrega", b =>
                {
                    b.Property<int>("IdEntrega")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Entrega")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdEntrega");

                    b.ToTable("Tipo_Entrega");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.TipoSesionFotografica", b =>
                {
                    b.Property<int>("IdTipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Tipo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Costo")
                        .HasColumnType("int");

                    b.Property<string>("DescripciónSesion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Descripción_Sesion");

                    b.HasKey("IdTipo");

                    b.ToTable("Tipo_SesionFotografica");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.Usuario", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_User")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Passcode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("passcode");

                    b.HasKey("IdUser");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.Reserva", b =>
                {
                    b.HasOne("Photo_StudioAPI.Models.Usuario", "IdReservaNavigation")
                        .WithMany("Reservas")
                        .HasForeignKey("IdReserva")
                        .HasConstraintName("FK_Reserva_Usuario1")
                        .IsRequired();

                    b.HasOne("Photo_StudioAPI.Models.TipoEntrega", "TipoEntregaNavigation")
                        .WithMany("Reservas")
                        .HasForeignKey("TipoEntrega")
                        .HasConstraintName("FK_Reserva_Tipo_Entrega")
                        .IsRequired();

                    b.HasOne("Photo_StudioAPI.Models.TipoSesionFotografica", "TipoSesionNavigation")
                        .WithMany("Reservas")
                        .HasForeignKey("TipoSesion")
                        .HasConstraintName("FK_Reserva_Tipo_SesionFotografica")
                        .IsRequired();

                    b.Navigation("IdReservaNavigation");

                    b.Navigation("TipoEntregaNavigation");

                    b.Navigation("TipoSesionNavigation");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.Sesion", b =>
                {
                    b.HasOne("Photo_StudioAPI.Models.EstadoSesion", "Status")
                        .WithMany("Sesions")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("FK__Sesion__Status_I__00DF2177")
                        .IsRequired();

                    b.HasOne("Photo_StudioAPI.Models.FotosStatus", "StatusNavigation")
                        .WithMany("Sesions")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("FK_Sesion_Fotos_Status")
                        .IsRequired();

                    b.HasOne("Photo_StudioAPI.Models.Reserva", "Reserva")
                        .WithMany("Sesions")
                        .HasForeignKey("ReservaId", "UsuarioId")
                        .HasConstraintName("FK__Sesion__308E3499")
                        .IsRequired();

                    b.Navigation("Reserva");

                    b.Navigation("Status");

                    b.Navigation("StatusNavigation");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.EstadoSesion", b =>
                {
                    b.Navigation("Sesions");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.FotosStatus", b =>
                {
                    b.Navigation("Sesions");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.Reserva", b =>
                {
                    b.Navigation("Sesions");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.TipoEntrega", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.TipoSesionFotografica", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Photo_StudioAPI.Models.Usuario", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
