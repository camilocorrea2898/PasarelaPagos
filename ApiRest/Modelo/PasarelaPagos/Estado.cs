using System;
using System.Collections.Generic;

#nullable disable

namespace ApiRest.Modelo.PasarelaPagos
{
    public partial class Estado
    {
        public Estado()
        {
            Transacciones = new HashSet<Transaccione>();
        }

        public int IdEstado { get; set; }
        public string Estado1 { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual ICollection<Transaccione> Transacciones { get; set; }
    }
}
