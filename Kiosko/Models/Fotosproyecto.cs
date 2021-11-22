using System;
using System.Collections.Generic;

#nullable disable

namespace Kiosko.Models
{
    public partial class Fotosproyecto
    {
        public int Idfotoproyecto { get; set; }
        public int? Idproyectos { get; set; }
        public string Fotoproyecto { get; set; }

        public virtual Proyecto IdproyectosNavigation { get; set; }
    }
}
