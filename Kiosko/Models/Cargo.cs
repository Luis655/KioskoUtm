using System;
using System.Collections.Generic;

#nullable disable

namespace Kiosko.Models
{
    public partial class Cargo
    {
        public Cargo()
        {
            Registrosalumnos = new HashSet<Registrosalumno>();
            Registrosprofesores = new HashSet<Registrosprofesore>();
        }

        public int Idcargo { get; set; }
        public string Cargo1 { get; set; }

        public virtual ICollection<Registrosalumno> Registrosalumnos { get; set; }
        public virtual ICollection<Registrosprofesore> Registrosprofesores { get; set; }
    }
}
