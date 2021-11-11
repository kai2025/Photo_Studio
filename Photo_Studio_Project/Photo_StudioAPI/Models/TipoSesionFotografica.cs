using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

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

        [Key]
        [Column("ID_Tipo")]
        public int IdTipo { get; set; }
        [Required]
        [Column("Descripción_Sesion")]
        [StringLength(100)]
        public string DescripciónSesion { get; set; }
        public int? Costo { get; set; }

        [InverseProperty(nameof(Reserva.TipoSesionNavigation))]
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
