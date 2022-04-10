using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Model.PasarelaPagos
{
    public partial class Cliente
    {
        public Cliente()
        {
            Carteras = new HashSet<Cartera>();
        }

        public int IdCliente { get; set; }
        public string NombresCliente { get; set; }
        public string Genero { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual ICollection<Cartera> Carteras { get; set; }
    }
}
