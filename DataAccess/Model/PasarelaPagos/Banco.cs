using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Model.PasarelaPagos
{
    public partial class Banco
    {
        public Banco()
        {
            Transacciones = new HashSet<Transaccione>();
        }

        public int IdBanco { get; set; }
        public string Banco1 { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual ICollection<Transaccione> Transacciones { get; set; }
    }
}
