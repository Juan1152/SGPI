using System;
using System.Collections.Generic;

namespace SGPI.Models
{
    public partial class Programacion
    {
        public int IdProgramacion { get; set; }
        public string PeriodoAcademico { get; set; } = null!;
        public int IdPrograma { get; set; }
        public DateTime FechaProgramacion { get; set; }
        public string Sala { get; set; } = null!;
        public int IdAsignatura { get; set; }
        public int IdUsuario { get; set; }

        public virtual Asignatura IdAsignaturaNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}
