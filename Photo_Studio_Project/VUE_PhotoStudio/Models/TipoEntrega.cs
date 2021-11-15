using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Photo_StudioAPI.Models
{
    [Table("Tipo_Entrega")]
    public partial class TipoEntrega
    {
        public TipoEntrega()
        {
            Reservas = new HashSet<Reserva>();
        }


        public int IdEntrega { get; set; }

        public string Descripcion { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
