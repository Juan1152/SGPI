using System;
using System.Collections.Generic;

namespace SGPI.Models
{
    public partial class TipoHomologacion
    {
        public TipoHomologacion()
        {
            Homologacions = new HashSet<Homologacion>();
        }

        public int IdTipoHomologacion { get; set; }
        public string TipoHomologacion1 { get; set; } = null!;

        public virtual ICollection<Homologacion> Homologacions { get; set; }
    }
}
