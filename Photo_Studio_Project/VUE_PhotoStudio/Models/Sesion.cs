using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Photo_StudioAPI.Models
{
    [Table("Sesion")]
    public partial class Sesion
    {

        public int IdSesion { get; set; }

        public int UsuarioId { get; set; }

        public int ReservaId { get; set; }

        public int StatusId { get; set; }


        public virtual Reserva Reserva { get; set; }
        [ForeignKey(nameof(StatusId))]

        public virtual EstadoSesion Status { get; set; }
        [ForeignKey(nameof(StatusId))]

        public virtual FotosStatus StatusNavigation { get; set; }
    }
}
