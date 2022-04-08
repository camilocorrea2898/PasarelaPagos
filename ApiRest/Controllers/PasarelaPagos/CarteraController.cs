using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiRest.Controllers.PasarelaPagos
{
    [Route("[controller]")]
    [ApiController]
    public class CarteraController : ControllerBase
    {
        private NLog.Logger _logger;
        private readonly string _IdLog;

        public CarteraController()
        {
            _logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            _IdLog = $"{DateTime.Now:yyyyMMddhhmmssff} - ";
        }

        // GET PasarelaPagos/CarteraCliente/123456
        [HttpGet("CarteraCliente/{IdCliente}")]
        public Modelo.PasarelaPagos.Cartera CarteraCliente(string Mensaje)
        {
            Modelo.PasarelaPagos.Cartera ObjRespuesta = new();

            try
            {
                //Clases.Ejemplo ObjMetodo = new();
                //ObjRespuesta = ObjMetodo.DevolverMensaje(Mensaje);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el método DevolverMensaje: {ex.Message}");
                //bjRespuesta.Mensaje = $"Excepción: {ex.Message}";
            }
            return ObjRespuesta;
        }
    }
}
