using System;
using System.Collections.Generic;

#nullable disable

namespace Kiosko.Models
{
    public partial class Grdoygrupo
    {
        public Grdoygrupo()
        {
            Registrosalumnos = new HashSet<Registrosalumno>();
        }

        public int Idgradoygrupo { get; set; }
        public string Gradoygrupo { get; set; }

        public virtual ICollection<Registrosalumno> Registrosalumnos { get; set; }
    }
}
