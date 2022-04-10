using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Model.PasarelaPagos
{
    public partial class ActividadesEconomica
    {
        public ActividadesEconomica()
        {
            Comercios = new HashSet<Comercio>();
        }

        public int IdActividadEconomica { get; set; }
        public decimal? Mcc { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual ICollection<Comercio> Comercios { get; set; }
    }
}
