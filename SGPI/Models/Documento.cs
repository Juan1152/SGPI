using System;
using System.Collections.Generic;

namespace SGPI.Models
{
    public partial class Documento
    {
        public Documento()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdDoc { get; set; }
        public string TipoDocumento { get; set; } = null!;

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
