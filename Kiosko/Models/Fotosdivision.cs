using System;
using System.Collections.Generic;

#nullable disable

namespace Kiosko.Models
{
    public partial class Fotosdivision
    {
        public int Idfotodivision { get; set; }
        public int? Iddivisiones { get; set; }
        public string Fotodivision { get; set; }

        public virtual Divisione IddivisionesNavigation { get; set; }
    }
}
