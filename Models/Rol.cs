using System;
using System.Collections.Generic;

namespace SGPI.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdRol { get; set; }
        public string Rol1 { get; set; } = null!;

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
