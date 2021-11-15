using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int IdStatus { get; set; }

        public string DescripciónStatus { get; set; }


        public virtual ICollection<Sesion> Sesions { get; set; }
    }
}
