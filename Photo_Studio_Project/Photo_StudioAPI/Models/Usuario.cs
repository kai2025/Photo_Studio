using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Photo_StudioAPI.Models
{
    [Table("Usuario")]
    public partial class Usuario
    {
        public Usuario()
        {
            Reservas = new HashSet<Reserva>();
        }

        [Key]
        [Column("ID_User")]
        public int IdUser { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [Column("passcode")]
        [StringLength(50)]
        public string Passcode { get; set; }

        [InverseProperty(nameof(Reserva.IdReservaNavigation))]
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
