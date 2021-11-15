using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Photo_StudioAPI.Models
{
    public partial class SesionEntrega
    {
        [Column("Reserva No.")]
        public int ReservaNo { get; set; }
        [Column("Sesion No.")]
        public int SesionNo { get; set; }
        [Required]
        [StringLength(100)]
        public string Usuario { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("Entrega de fotos")]
        public int EntregaDeFotos { get; set; }
    }
}
