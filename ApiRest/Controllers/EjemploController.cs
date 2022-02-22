using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Controllers
{
    [Route("PasarelaDePagos")]
    [ApiController]
    public class EjemploController : ControllerBase
    {
        private NLog.Logger _logger;
        private readonly string _IdLog;


        public EjemploController()
        {
            _logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            _IdLog = $"{DateTime.Now:yyyyMMddhhmmssff} - ";
        }

        // GET PasarelaPagos/DevolverMensaje/Hola Mundo
        [HttpGet("DevolverMensaje/{Mensaje}")]
        public Clases.Dto.Respuesta DevolverMensaje(string Mensaje)
        {
            Clases.Dto.Respuesta ObjRespuesta = new();
            
            try
            {
                Clases.Ejemplo ObjMetodo = new();
                ObjRespuesta = ObjMetodo.DevolverMensaje(Mensaje);
            }
            catch(Exception ex)
            {
                _logger.Error($"Excepción en el método DevolverMensaje: {ex.Message}");
                ObjRespuesta.Mensaje = $"Excepción: {ex.Message}";
            }
            return ObjRespuesta;
        }
    }
}
