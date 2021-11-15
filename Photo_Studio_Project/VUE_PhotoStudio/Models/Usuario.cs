using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int IdUser { get; set; }

        public string Nombre { get; set; }
 
        public string Email { get; set; }

        public string Passcode { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
