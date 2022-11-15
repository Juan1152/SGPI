using System;
using System.Collections.Generic;

namespace SGPI.Models
{
    public partial class Programa
    {
        public Programa()
        {
            Asignaturas = new HashSet<Asignatura>();
            Homologacions = new HashSet<Homologacion>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdPrograma { get; set; }
        public string Programa1 { get; set; } = null!;

        public virtual ICollection<Asignatura> Asignaturas { get; set; }
        public virtual ICollection<Homologacion> Homologacions { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
