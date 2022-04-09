using ApiRest.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ApiRest.Controllers.Cartera
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

        // GET  Cartera/TraerCarteras
        [HttpGet("TraerCarteras")]
        public List<DAO.CarteraDTO.Cartera> TraerCarteras()
        {
            List<DAO.CarteraDTO.Cartera> ObjRespuesta = new();
            try
            {
                DAO.Cartera.Cartera ObjMetodo = new(_logger,_IdLog);
                ObjRespuesta = ObjMetodo.TraerCarteras();
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador TraerCarteras: {ex.Message}");
            }
            return ObjRespuesta;
        }

        // GET  Cartera/TraerCarterasPorIdCartera/123456
        [HttpGet("TraerCarterasPorIdCartera/{IdCartera}")]
        public List<DAO.CarteraDTO.Cartera> TraerCarterasPorIdCartera(int IdCartera)
        {
            List<DAO.CarteraDTO.Cartera> ObjRespuesta = new();
            try
            {
                DAO.Cartera.Cartera ObjMetodo = new(_logger, _IdLog);
                ObjRespuesta = ObjMetodo.TraerCarterasPorIdCartera(IdCartera);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador TraerCarterasPorIdCartera: {ex.Message}");
            }
            return ObjRespuesta;
        }

        // GET  Cartera/TraerCarterasPorIdComercio/123456
        [HttpGet("TraerCarterasPorIdComercio/{IdComercio}")]
        public List<DAO.CarteraDTO.Cartera> TraerCarterasPorIdComercio(int IdComercio)
        {
            List<DAO.CarteraDTO.Cartera> ObjRespuesta = new();
            try
            {
                DAO.Cartera.Cartera ObjMetodo = new(_logger, _IdLog);
                ObjRespuesta = ObjMetodo.TraerCarterasPorIdComercio(IdComercio);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador TraerCarterasPorIdComercio: {ex.Message}");
            }
            return ObjRespuesta;
        }

        // GET  Cartera/TraerCarterasPorIdCliente/123456
        [HttpGet("TraerCarterasPorIdCliente/{IdCliente}")]
        public List<DAO.CarteraDTO.Cartera> TraerCarterasPorIdCliente(int IdCliente)
        {
            List<DAO.CarteraDTO.Cartera> ObjRespuesta = new();
            try
            {
                DAO.Cartera.Cartera ObjMetodo = new(_logger, _IdLog);
                ObjRespuesta = ObjMetodo.TraerCarterasPorIdCliente(IdCliente);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador TraerCarterasPorIdCliente: {ex.Message}");
            }
            return ObjRespuesta;
        }

        // GET  Cartera/TraerCarterasHabilesPorIdCliente/123456
        [HttpGet("TraerCarterasHabilesPorIdCliente/{IdCliente}")]
        public List<DAO.CarteraDTO.Cartera> TraerCarterasHabilesPorIdCliente(int IdCliente)
        {
            List<DAO.CarteraDTO.Cartera> ObjRespuesta = new();
            try
            {
                DAO.Cartera.Cartera ObjMetodo = new(_logger, _IdLog);
                ObjRespuesta = ObjMetodo.TraerCarterasHabilesPorIdCliente(IdCliente);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador TraerCarterasHabilesPorIdCliente: {ex.Message}");
            }
            return ObjRespuesta;
        }

        // GET  Cartera/TraerCarterasPendientesPorIdCliente/123456
        [HttpGet("TraerCarterasPendientesPorIdCliente/{IdCliente}")]
        public List<DAO.CarteraDTO.Cartera> TraerCarterasPendientesPorIdCliente(int IdCliente)
        {
            List<DAO.CarteraDTO.Cartera> ObjRespuesta = new();
            try
            {
                DAO.Cartera.Cartera ObjMetodo = new(_logger, _IdLog);
                ObjRespuesta = ObjMetodo.TraerCarterasPendientesPorIdCliente(IdCliente);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador TraerCarterasHabilesPorIdCliente: {ex.Message}");
            }
            return ObjRespuesta;
        }

        // POST  Cartera/InsertarCartera
        [HttpPost("InsertarCartera")]
        public Respuesta InsertarCartera(DAO.CarteraDTO.Cartera ObjInsertar)
        {
            Respuesta ObjRespuesta = new();
            try
            {
                DAO.Cartera.Cartera ObjMetodo = new(_logger, _IdLog);
                ObjRespuesta = ObjMetodo.InsertarCartera(ObjInsertar);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador InsertarCartera: {ex.Message}");
            }
            return ObjRespuesta;
        }

        // PUT  Cartera/ActualizarCartera/123456
        [HttpPut("ActualizarCartera/{IdCartera}")]
        public Respuesta ActualizarCartera(int IdCartera,DAO.CarteraDTO.Cartera ObjActualizar)
        {
            Respuesta ObjRespuesta = new();
            try
            {
                DAO.Cartera.Cartera ObjMetodo = new(_logger, _IdLog);
                ObjRespuesta = ObjMetodo.ActualizarCartera(ObjActualizar);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador ActualizarCartera: {ex.Message}");
            }
            return ObjRespuesta;
        }

        // DELETE  Cartera/EliminarCartera/123456
        [HttpDelete("EliminarCartera/{IdCartera}")]
        public Respuesta EliminarCartera(int IdCartera)
        {
            Respuesta ObjRespuesta = new();
            try
            {
                DAO.Cartera.Cartera ObjMetodo = new(_logger, _IdLog);
                ObjRespuesta = ObjMetodo.EliminarCartera(IdCartera);
            }
            catch (Exception ex)
            {
                _logger.Error($"Excepción en el controlador EliminarCartera: {ex.Message}");
            }
            return ObjRespuesta;
        }
    }
}
