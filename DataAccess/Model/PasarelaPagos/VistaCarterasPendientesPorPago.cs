using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Model.PasarelaPagos
{
    public partial class VistaCarterasPendientesPorPago
    {
        public int IdCartera { get; set; }
        public int? IdComercio { get; set; }
        public int? IdCliente { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
