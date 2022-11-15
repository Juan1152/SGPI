using System;
using System.Collections.Generic;

namespace SGPI.Models
{
    public partial class Asignatura
    {
        public Asignatura()
        {
            Homologacions = new HashSet<Homologacion>();
            Programacions = new HashSet<Programacion>();
        }

        public int IdAsignatura { get; set; }
        public string? Nombre { get; set; }
        public string? Codigo { get; set; }
        public int? IdPrograma { get; set; }
        public int? Nivel { get; set; }
        public int? Creditos { get; set; }

        public virtual Programa? IdProgramaNavigation { get; set; }
        public virtual ICollection<Homologacion> Homologacions { get; set; }
        public virtual ICollection<Programacion> Programacions { get; set; }
    }
}
