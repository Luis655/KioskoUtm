using System;
using System.Collections.Generic;

#nullable disable

namespace Kiosko.Models
{
    public partial class Registrosprofesore
    {
        public int Idprofesor { get; set; }
        public string Nombre { get; set; }
        public string Apellidop { get; set; }
        public string Apellidom { get; set; }
        public int Iddivisiones { get; set; }
        public int? Idproyectos { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime? Fechanac { get; set; }
        public int Idstatus { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public int? Idcargo { get; set; }
        public string Fotoprofesor { get; set; }

        public virtual Cargo IdcargoNavigation { get; set; }
        public virtual Divisione IddivisionesNavigation { get; set; }
        public virtual Proyecto IdproyectosNavigation { get; set; }
        public virtual Statususuario IdstatusNavigation { get; set; }
    }
}
