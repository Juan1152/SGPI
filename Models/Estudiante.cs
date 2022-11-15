using System;
using System.Collections.Generic;

namespace SGPI.Models
{
    public partial class Estudiante
    {
        public Estudiante()
        {
            Entrevista = new HashSet<Entrevistum>();
            Homologacions = new HashSet<Homologacion>();
        }

        public int IdEstudiante { get; set; }
        public string Archivo { get; set; } = null!;
        public int IdPago { get; set; }
        public int IdUsuario { get; set; }
        public bool Egreado { get; set; }

        public virtual Pago IdPagoNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
        public virtual ICollection<Entrevistum> Entrevista { get; set; }
        public virtual ICollection<Homologacion> Homologacions { get; set; }
    }
}
