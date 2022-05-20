using DataAccess.Data.PasarelaPagos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ApiRest.Controllers.PasarelaPagos.Cartera
{
    [Route("[controller]")]
    [ApiController]
    public class CarteraController : ControllerBase
    {
        private readonly NLog.Logger _logger;
        private readonly string _IdLog;
        private DataAccess.Data.PasarelaPagos.Cartera ObjMetodo;
        private List<CarteraDto> ObjRespuestaList;
        private DataAccess.Respuesta ObjRespuestaDML;
        public CarteraController()
        {
            _logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            _IdLog = $"{DateTime.Now:yyyyMMddhhmmssff} - ";
            ObjMetodo = new(_logger, _IdLog);
        }

        // GET  Cartera/TraerCarteras
        [HttpGet("TraerCarteras")]
        public List<CarteraDto> TraerCarteras()
        {
            try
            {
                ObjRespuestaList = ObjMetodo.TraerCarteras();
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador TraerCarteras: {ex.Message}");
            }
            return ObjRespuestaList;
        }

        // GET  Cartera/TraerCarterasPorIdCartera/123456
        [HttpGet("TraerCarterasPorIdCartera/{IdCartera}")]
        public List<CarteraDto> TraerCarterasPorIdCartera(int IdCartera)
        {
            try
            {
                ObjRespuestaList = ObjMetodo.TraerCarterasPorIdCartera(IdCartera);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador TraerCarterasPorIdCartera: {ex.Message}");
            }
            return ObjRespuestaList;
        }

        // GET  Cartera/TraerCarterasPorIdComercio/123456
        [HttpGet("TraerCarterasPorIdComercio/{IdComercio}")]
        public List<CarteraDto> TraerCarterasPorIdComercio(int IdComercio)
        {
            try
            {
                ObjRespuestaList = ObjMetodo.TraerCarterasPorIdComercio(IdComercio);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador TraerCarterasPorIdComercio: {ex.Message}");
            }
            return ObjRespuestaList;
        }

        // GET  Cartera/TraerCarterasPorIdCliente/123456
        [HttpGet("TraerCarterasPorIdCliente/{IdCliente}")]
        public List<CarteraDto> TraerCarterasPorIdCliente(int IdCliente)
        {
            try
            {
                ObjRespuestaList = ObjMetodo.TraerCarterasPorIdCliente(IdCliente);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador TraerCarterasPorIdCliente: {ex.Message}");
            }
            return ObjRespuestaList;
        }

        // GET  Cartera/TraerCarterasHabilesPorIdCliente/123456
        [HttpGet("TraerCarterasHabilesPorIdCliente/{IdCliente}")]
        public List<CarteraDto> TraerCarterasHabilesPorIdCliente(int IdCliente)
        {
            try
            {
                ObjRespuestaList = ObjMetodo.TraerCarterasHabilesPorIdCliente(IdCliente);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador TraerCarterasHabilesPorIdCliente: {ex.Message}");
            }
            return ObjRespuestaList;
        }

        // GET  Cartera/TraerCarterasPendientesPorIdCliente/123456
        [HttpGet("TraerCarterasPendientesPorIdCliente/{IdCliente}")]
        public List<CarteraDto> TraerCarterasPendientesPorIdCliente(int IdCliente)
        {
            try
            {
                ObjRespuestaList = ObjMetodo.TraerCarterasPendientesPorIdCliente(IdCliente);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador TraerCarterasHabilesPorIdCliente: {ex.Message}");
            }
            return ObjRespuestaList;
        }

        // POST  Cartera/InsertarCartera
        [HttpPost("InsertarCartera")]
        public DataAccess.Respuesta InsertarCartera(CarteraDto ObjInsertar)
        {
            try
            {
                ObjRespuestaDML = ObjMetodo.InsertarCartera(ObjInsertar);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador InsertarCartera: {ex.Message}");
            }
            return ObjRespuestaDML;
        }

        // PUT  Cartera/ActualizarCartera/123456
        [HttpPut("ActualizarCartera/{IdCartera}")]
        public DataAccess.Respuesta ActualizarCartera(int IdCartera,CarteraDto ObjActualizar)
        {
            try
            {
                ObjRespuestaDML = ObjMetodo.ActualizarCartera(ObjActualizar);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador ActualizarCartera: {ex.Message}");
            }
            return ObjRespuestaDML;
        }

        // DELETE  Cartera/EliminarCartera/123456
        [HttpDelete("EliminarCartera/{IdCartera}")]
        public DataAccess.Respuesta EliminarCartera(int IdCartera)
        {
            try
            {
                ObjRespuestaDML = ObjMetodo.EliminarCartera(IdCartera);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador EliminarCartera: {ex.Message}");
            }
            return ObjRespuestaDML;
        }
    }
}
