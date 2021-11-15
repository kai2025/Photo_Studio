using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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


        public int IdStatus { get; set; }

        public string Descripcion { get; set; }

        public virtual ICollection<Sesion> Sesions { get; set; }
    }
}
