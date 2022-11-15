using System;
using System.Collections.Generic;

namespace SGPI.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Entrevista = new HashSet<Entrevistum>();
            Estudiantes = new HashSet<Estudiante>();
            Programacions = new HashSet<Programacion>();
        }

        public int IdUsuario { get; set; } 
        public string NumeroDocumento { get; set; } = null!;
        public int IdDoc { get; set; }
        public string PrimerNombre { get; set; } = null!;
        public string? SegundoNombre { get; set; }
        public string PrimerApellido { get; set; } = null!;
        public string SegundoApellido { get; set; } = null!;
        public int IdGenero { get; set; }
        public string Email { get; set; } = null!;
        public int IdRol { get; set; }
        public string Password { get; set; } = null!;
        public int IdPrograma { get; set; }

        public virtual Documento IdDocNavigation { get; set; } = null!;
        public virtual Genero IdGeneroNavigation { get; set; } = null!;
        public virtual Programa IdProgramaNavigation { get; set; } = null!;
        public virtual Rol IdRolNavigation { get; set; } = null!;
        public virtual ICollection<Entrevistum> Entrevista { get; set; }
        public virtual ICollection<Estudiante> Estudiantes { get; set; }
        public virtual ICollection<Programacion> Programacions { get; set; }

       
    }
}
