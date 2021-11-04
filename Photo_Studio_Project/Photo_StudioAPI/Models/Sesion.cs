using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Photo_StudioAPI.Models
{
    [Table("Sesion")]
    public partial class Sesion
    {
        [Key]
        [Column("ID_Sesion")]
        public int IdSesion { get; set; }
        [Key]
        [Column("Usuario_ID")]
        public int UsuarioId { get; set; }
        [Key]
        [Column("Reserva_ID")]
        public int ReservaId { get; set; }
        [Column("Status_ID")]
        public int StatusId { get; set; }

        [ForeignKey("ReservaId,UsuarioId")]
        [InverseProperty("Sesions")]
        public virtual Reserva Reserva { get; set; }
        [ForeignKey(nameof(StatusId))]
        [InverseProperty(nameof(EstadoSesion.Sesions))]
        public virtual EstadoSesion Status { get; set; }
        [ForeignKey(nameof(StatusId))]
        [InverseProperty(nameof(FotosStatus.Sesions))]
        public virtual FotosStatus StatusNavigation { get; set; }
    }
}
