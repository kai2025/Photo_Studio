using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Photo_StudioAPI.Models
{
    [Table("Fotos_Status")]
    public partial class FotosStatus
    {
        public FotosStatus()
        {
            Sesions = new HashSet<Sesion>();
        }

        [Key]
        [Column("ID_Status")]
        public int IdStatus { get; set; }
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [InverseProperty(nameof(Sesion.StatusNavigation))]
        public virtual ICollection<Sesion> Sesions { get; set; }
    }
}
