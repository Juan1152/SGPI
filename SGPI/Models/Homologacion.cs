using System;
using System.Collections.Generic;

namespace SGPI.Models
{
    public partial class Homologacion
    {
        public int IdHomologacion { get; set; }
        public int IdEstudiante { get; set; }
        public int IdPrograma { get; set; }
        public int IdTipoHomologacion { get; set; }
        public string PeriodoAcademico { get; set; } = null!;
        public int IdAsignatura { get; set; }
        public string CodigoHomologacion { get; set; } = null!;
        public string NomAsigHomologacion { get; set; } = null!;
        public int CreditosHomologacion { get; set; }
        public double Nota { get; set; }

        public virtual Asignatura IdAsignaturaNavigation { get; set; } = null!;
        public virtual Estudiante IdEstudianteNavigation { get; set; } = null!;
        public virtual Programa IdProgramaNavigation { get; set; } = null!;
        public virtual TipoHomologacion IdTipoHomologacionNavigation { get; set; } = null!;
    }
}
