using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Model.PasarelaPagos
{
    public partial class Comercio
    {
        public Comercio()
        {
            Carteras = new HashSet<Cartera>();
        }

        public int IdComercio { get; set; }
        public string NombreComercio { get; set; }
        public string NitComercio { get; set; }
        public int? IdActividadEconomica { get; set; }
        public string CamaraComercio { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual ActividadesEconomica IdActividadEconomicaNavigation { get; set; }
        public virtual ICollection<Cartera> Carteras { get; set; }
    }
}
