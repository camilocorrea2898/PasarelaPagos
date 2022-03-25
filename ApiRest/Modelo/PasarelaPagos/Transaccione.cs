using System;
using System.Collections.Generic;

#nullable disable

namespace ApiRest.Modelo.PasarelaPagos
{
    public partial class Transaccione
    {
        public int IdTransaccion { get; set; }
        public int? IdCartera { get; set; }
        public int? IdFranquicia { get; set; }
        public int? IdBanco { get; set; }
        public int? IdEstado { get; set; }
        public string NumeroTarjeta { get; set; }
        public string Cvv2 { get; set; }
        public string FechaVencimientoTarjeta { get; set; }
        public decimal? Valor { get; set; }
        public int? Cuotas { get; set; }
        public string NombreUsuario { get; set; }
        public string CorreoUsuario { get; set; }
        public string CelularUsuario { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual Banco IdBancoNavigation { get; set; }
        public virtual Cartera IdCarteraNavigation { get; set; }
        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual Franquicia IdFranquiciaNavigation { get; set; }
    }
}
