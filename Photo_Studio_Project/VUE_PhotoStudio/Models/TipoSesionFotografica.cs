using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Photo_StudioAPI.Models
{
    [Table("Tipo_SesionFotografica")]
    public partial class TipoSesionFotografica
    {
        public TipoSesionFotografica()
        {
            Reservas = new HashSet<Reserva>();
        }


        public int IdTipo { get; set; }

        public string DescripciónSesion { get; set; }
        public int? Costo { get; set; }

        [InverseProperty(nameof(Reserva.TipoSesionNavigation))]
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
