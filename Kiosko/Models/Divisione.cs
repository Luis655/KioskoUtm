using System;
using System.Collections.Generic;

#nullable disable

namespace Kiosko.Models
{
    public partial class Divisione
    {
        public Divisione()
        {
            Fotosdivisions = new HashSet<Fotosdivision>();
            Proyectos = new HashSet<Proyecto>();
            Registrosalumnos = new HashSet<Registrosalumno>();
            Registrosprofesores = new HashSet<Registrosprofesore>();
        }

        public int Iddivisiones { get; set; }
        public string Nombredivision { get; set; }
        public string Coordinador { get; set; }
        public string Descripciondivision { get; set; }
        public string Planestudio { get; set; }
        public string Videodivision { get; set; }
        public string Fotodivision { get; set; }

        public virtual ICollection<Fotosdivision> Fotosdivisions { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
        public virtual ICollection<Registrosalumno> Registrosalumnos { get; set; }
        public virtual ICollection<Registrosprofesore> Registrosprofesores { get; set; }
    }
}
