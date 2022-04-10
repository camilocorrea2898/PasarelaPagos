using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class ConexionBd
    {
        public static string PasarelaPagosConnectionString = "";
        public static string SetPasarelaPagosConnectionString(IConfiguration config)
        {
            PasarelaPagosConnectionString = config.GetConnectionString("PasarelaPagosConnectionString");
            return PasarelaPagosConnectionString;
        }
    }
}
