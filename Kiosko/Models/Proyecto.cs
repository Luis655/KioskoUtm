using System;
using System.Collections.Generic;

#nullable disable

namespace Kiosko.Models
{
    public partial class Proyecto
    {
        public Proyecto()
        {
            Fotosproyectos = new HashSet<Fotosproyecto>();
            Registrosalumnos = new HashSet<Registrosalumno>();
            Registrosprofesores = new HashSet<Registrosprofesore>();
        }

        public int Idproyectos { get; set; }
        public string Nombreproyecto { get; set; }
        public int? Iddivisiones { get; set; }
        public string Videoproyecto { get; set; }
        public string Descripcionproyecto { get; set; }
        public string Fotoproyecto { get; set; }

        public virtual Divisione IddivisionesNavigation { get; set; }
        public virtual ICollection<Fotosproyecto> Fotosproyectos { get; set; }
        public virtual ICollection<Registrosalumno> Registrosalumnos { get; set; }
        public virtual ICollection<Registrosprofesore> Registrosprofesores { get; set; }
    }
}
