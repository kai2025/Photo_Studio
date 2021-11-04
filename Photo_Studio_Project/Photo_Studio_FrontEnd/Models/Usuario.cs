using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photo_Studio_FrontEnd.Models
{
    public class Usuario
    {
        public int IdUser { get; set; }

        public string Nombre { get; set; }

        public string Email { get; set; }

        public string Passcode { get; set; }
    }
}
