using System;
using System.Collections.Generic;

#nullable disable

namespace ApiRest.Modelo.PasarelaPagos
{
    public partial class Cartera
    {
        public Cartera()
        {
            Transacciones = new HashSet<Transaccione>();
        }

        public int IdCartera { get; set; }
        public int? IdComercio { get; set; }
        public int? IdCliente { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Comercio IdComercioNavigation { get; set; }
        public virtual ICollection<Transaccione> Transacciones { get; set; }
    }
}
