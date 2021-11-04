using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

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

        [Key]
        [Column("ID_Entrega")]
        public int IdEntrega { get; set; }
        [Required]
        [StringLength(20)]
        public string Descripcion { get; set; }

        [InverseProperty(nameof(Reserva.TipoEntregaNavigation))]
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
