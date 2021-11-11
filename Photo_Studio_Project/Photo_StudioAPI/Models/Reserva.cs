using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Photo_StudioAPI.Models
{
    [Table("Reserva")]
    public partial class Reserva
    {
        public Reserva()
        {
            Sesions = new HashSet<Sesion>();
        }

        [Key]
        [Column("ID_Reserva")]
        public int IdReserva { get; set; }
        [Key]
        [Column("UserID")]
        public int UserId { get; set; }
        [Column("Fecha_Hora", TypeName = "datetime")]
        public DateTime FechaHora { get; set; }
        [Column("Tipo_Sesion")]
        public int TipoSesion { get; set; }
        [Column("Rev_status")]
        public int RevStatus { get; set; }
        [Column("Tipo_Entrega")]
        public int TipoEntrega { get; set; }

        [ForeignKey(nameof(IdReserva))]
        [InverseProperty(nameof(Usuario.Reservas))]
        public virtual Usuario IdReservaNavigation { get; set; }
        [ForeignKey(nameof(TipoEntrega))]
        [InverseProperty("Reservas")]
        public virtual TipoEntrega TipoEntregaNavigation { get; set; }
        [ForeignKey(nameof(TipoSesion))]
        [InverseProperty(nameof(TipoSesionFotografica.Reservas))]
        public virtual TipoSesionFotografica TipoSesionNavigation { get; set; }
        [InverseProperty(nameof(Sesion.Reserva))]
        public virtual ICollection<Sesion> Sesions { get; set; }
    }
}
