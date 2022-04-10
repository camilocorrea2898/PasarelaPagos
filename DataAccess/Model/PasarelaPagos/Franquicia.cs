using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Model.PasarelaPagos
{
    public partial class Franquicia
    {
        public Franquicia()
        {
            Transacciones = new HashSet<Transaccione>();
        }

        public int IdFranquicia { get; set; }
        public string Franquicia1 { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual ICollection<Transaccione> Transacciones { get; set; }
    }
}
