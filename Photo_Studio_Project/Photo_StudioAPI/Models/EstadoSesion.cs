using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Photo_StudioAPI.Models
{
    [Table("Estado_Sesion")]
    public partial class EstadoSesion
    {
        public EstadoSesion()
        {
            Sesions = new HashSet<Sesion>();
        }

        [Key]
        [Column("ID_Status")]
        public int IdStatus { get; set; }
        [Required]
        [Column("Descripción_Status")]
        [StringLength(100)]
        public string DescripciónStatus { get; set; }

        [InverseProperty(nameof(Sesion.Status))]
        public virtual ICollection<Sesion> Sesions { get; set; }
    }
}
