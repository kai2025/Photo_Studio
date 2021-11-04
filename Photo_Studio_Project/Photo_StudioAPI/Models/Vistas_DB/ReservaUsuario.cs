using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Photo_StudioAPI.Models
{
    [Keyless]
    public partial class ReservaUsuario
    {
        [Column("No. Usuario")]
        public int NoUsuario { get; set; }
        [Required]
        [StringLength(100)]
        public string Cliente { get; set; }
        [Required]
        [Column("Correo Electronico")]
        [StringLength(100)]
        public string CorreoElectronico { get; set; }
        [Column("Reverva no.")]
        public int RevervaNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Required]
        [StringLength(100)]
        public string Detalle { get; set; }
        [Column(TypeName = "numeric(6, 2)")]
        public decimal Costo { get; set; }
    }
}
