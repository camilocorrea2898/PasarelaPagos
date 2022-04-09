using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.DAO
{
    public class ConnectionService
    {
        public static string PasarelaPagosConnectionString = "";
        public static string SetPasarelaPagosConnectionString(IConfiguration config)
        {
            PasarelaPagosConnectionString = config.GetConnectionString("PasarelaPagosConnectionString");
            return PasarelaPagosConnectionString;
        }
    }
}
