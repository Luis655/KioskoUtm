using System;
using System.Collections.Generic;

#nullable disable

namespace Kiosko.Models
{
    public partial class Statususuario
    {
        public Statususuario()
        {
            Registrosalumnos = new HashSet<Registrosalumno>();
            Registrosprofesores = new HashSet<Registrosprofesore>();
        }

        public int Idstatus { get; set; }
        public string Statususuario1 { get; set; }

        public virtual ICollection<Registrosalumno> Registrosalumnos { get; set; }
        public virtual ICollection<Registrosprofesore> Registrosprofesores { get; set; }
    }
}
