using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Data.PasarelaPagos
{
    public class Cartera
    {
        private readonly Model.PasarelaPagos.PasarelaPagosContext _context;
        private readonly NLog.Logger _logger;
        private readonly string _IdLog;

        public Cartera(NLog.Logger logger, string idLog){
            _context = new Model.PasarelaPagos.PasarelaPagosContext();
            _logger = logger;
            _IdLog = idLog;
        }
        public List<CarteraDto> TraerCarteras()
        {
            _logger.Debug(_IdLog + "Se van a obtener todos datos en la tabla Cartera:");
            try
            {
                var objReturnTable = _context.Carteras.ToList();
                List<CarteraDto> ObjGetData = new();
                foreach (var Data in objReturnTable)
                {
                    CarteraDto ObjItem = (new CarteraDto {
                        IdCartera = Data.IdCartera,
                        IdComercio = Data.IdComercio,
                        IdCliente = Data.IdCliente,
                        Descripcion = Data.Descripcion,
                        FechaInicio = Data.FechaInicio,
                        FechaFin = Data.FechaFin,
                        Valor = Data.Valor,
                        FechaCreacion = Data.FechaCreacion
                    });

                    ObjGetData.Add(ObjItem);
                }
                return ObjGetData;
            }
            catch (Exception ex)
            {
                _logger.Debug(_IdLog + "TraerCarteras Exception " + ex.Message);
                return null;
            }
        }
        public List<CarteraDto> TraerCarterasPorIdCartera(int IdCartera)
        {
            _logger.Debug(_IdLog + "Se van a obtener todos datos en la tabla Cartera por IdCartera:" + IdCartera);
            try
            {
                var objReturnTable = _context.Carteras.Where(x => x.IdCartera== IdCartera).ToList();
                List<CarteraDto> ObjGetData = new();
                foreach (var Data in objReturnTable)
                {
                    CarteraDto ObjItem = (new CarteraDto
                    {
                        IdCartera = Data.IdCartera,
                        IdComercio = Data.IdComercio,
                        IdCliente = Data.IdCliente,
                        Descripcion = Data.Descripcion,
                        FechaInicio = Data.FechaInicio,
                        FechaFin = Data.FechaFin,
                        Valor = Data.Valor,
                        FechaCreacion = Data.FechaCreacion
                    });

                    ObjGetData.Add(ObjItem);
                }
                return ObjGetData;
            }
            catch (Exception ex)
            {
                _logger.Debug(_IdLog + "TraerCarterasPorIdCartera Exception " + ex.Message);
                return null;
            }
        }
        public List<CarteraDto> TraerCarterasPorIdComercio(int IdComercio)
        {
            _logger.Debug(_IdLog + "Se van a obtener todos datos en la tabla Cartera por IdComercio:" + IdComercio);
            try
            {
                var objReturnTable = _context.Carteras.Where(x => x.IdComercio == IdComercio).ToList();
                List<CarteraDto> ObjGetData = new();
                foreach (var Data in objReturnTable)
                {
                    CarteraDto ObjItem = (new CarteraDto
                    {
                        IdCartera = Data.IdCartera,
                        IdComercio = Data.IdComercio,
                        IdCliente = Data.IdCliente,
                        Descripcion = Data.Descripcion,
                        FechaInicio = Data.FechaInicio,
                        FechaFin = Data.FechaFin,
                        Valor = Data.Valor,
                        FechaCreacion = Data.FechaCreacion
                    });

                    ObjGetData.Add(ObjItem);
                }
                return ObjGetData;
            }
            catch (Exception ex)
            {
                _logger.Debug(_IdLog + "TraerCarterasPorIdComercio Exception " + ex.Message);
                return null;
            }
        }
        public List<CarteraDto> TraerCarterasPorIdCliente(int IdCliente)
        {
            _logger.Debug(_IdLog + "Se van a obtener todos datos en la tabla Cartera por IdCliente:" + IdCliente);
            try
            {
                var objReturnTable = _context.Carteras.Where(x => x.IdCliente == IdCliente).ToList();
                List<CarteraDto> ObjGetData = new();
                foreach (var Data in objReturnTable)
                {
                    CarteraDto ObjItem = (new CarteraDto
                    {
                        IdCartera = Data.IdCartera,
                        IdComercio = Data.IdComercio,
                        IdCliente = Data.IdCliente,
                        Descripcion = Data.Descripcion,
                        FechaInicio = Data.FechaInicio,
                        FechaFin = Data.FechaFin,
                        Valor = Data.Valor,
                        FechaCreacion = Data.FechaCreacion
                    });

                    ObjGetData.Add(ObjItem);
                }
                return ObjGetData;
            }
            catch (Exception ex)
            {
                _logger.Debug(_IdLog + "TraerCarterasPorIdCliente Exception " + ex.Message);
                return null;
            }
        }
        public List<CarteraDto> TraerCarterasHabilesPorIdCliente(int IdCliente)
        {
            _logger.Debug(_IdLog + "Se van a obtener todos datos en la tabla Cartera habiles por IdCliente:" + IdCliente);
            try
            {
                var objReturnTable = _context.Carteras.Where(x => x.IdCliente == IdCliente && x.FechaFin<DateTime.Now && x.FechaFin>DateTime.Now).ToList();
                List<CarteraDto> ObjGetData = new();
                foreach (var Data in objReturnTable)
                {
                    CarteraDto ObjItem = (new CarteraDto
                    {
                        IdCartera = Data.IdCartera,
                        IdComercio = Data.IdComercio,
                        IdCliente = Data.IdCliente,
                        Descripcion = Data.Descripcion,
                        FechaInicio = Data.FechaInicio,
                        FechaFin = Data.FechaFin,
                        Valor = Data.Valor,
                        FechaCreacion = Data.FechaCreacion
                    });

                    ObjGetData.Add(ObjItem);
                }
                return ObjGetData;
            }
            catch (Exception ex)
            {
                _logger.Debug(_IdLog + "TraerCarterasHabilesPorIdCliente Exception " + ex.Message);
                return null;
            }
        }
        public List<CarteraDto> TraerCarterasPendientesPorIdCliente(int IdCliente)
        {
            _logger.Debug(_IdLog + "Se van a obtener todos datos en la tabla Cartera pendientes por pago por IdCliente:" + IdCliente);
            try
            {
                var objReturnTable = _context.Carteras.Where(x => x.IdCliente == IdCliente 
                    && x.FechaFin < DateTime.Now 
                    && x.FechaFin > DateTime.Now
                    )
                    .ToList();
                List<CarteraDto> ObjGetData = new();
                foreach (var Data in objReturnTable)
                {
                    CarteraDto ObjItem = (new CarteraDto
                    {
                        IdCartera = Data.IdCartera,
                        IdComercio = Data.IdComercio,
                        IdCliente = Data.IdCliente,
                        Descripcion = Data.Descripcion,
                        FechaInicio = Data.FechaInicio,
                        FechaFin = Data.FechaFin,
                        Valor = Data.Valor,
                        FechaCreacion = Data.FechaCreacion
                    });

                    ObjGetData.Add(ObjItem);
                }
                return ObjGetData;
            }
            catch (Exception ex)
            {
                _logger.Debug(_IdLog + "TraerCarterasHabilesPorIdCliente Exception " + ex.Message);
                return null;
            }
        }
        public Respuesta InsertarCartera(CarteraDto ObjInsertar)
        {
            Respuesta objReturn = new Respuesta();
            try
            {
                ObjInsertar.FechaCreacion = DateTime.Now;
                string objRequestLog = JsonConvert.SerializeObject(ObjInsertar, Formatting.Indented);
                _logger.Debug("--------------------------------------------------------------------");
                _logger.Debug(_IdLog + "Se va a insertar datos en la tabla Cartera: " + objRequestLog);
                try
                {
                    var ObjCartera = new Model.PasarelaPagos.Cartera()
                    {
                        IdComercio = ObjInsertar.IdComercio,
                        IdCliente = ObjInsertar.IdCliente,
                        Descripcion = ObjInsertar.Descripcion,
                        FechaInicio = ObjInsertar.FechaInicio,
                        FechaFin = ObjInsertar.FechaFin,
                        Valor = ObjInsertar.Valor,
                        FechaCreacion = ObjInsertar.FechaCreacion
                    };

                    _context.Carteras.Add(ObjCartera);
                    _context.SaveChanges();
                    if (ObjCartera.IdCartera > 0)
                    {
                        _logger.Debug(_IdLog + "Se agrego correctamente el IdCartera " + ObjCartera.IdCartera);
                        return objReturn.SeleccionarRespuesta(1, ObjCartera.IdCartera);
                    }
                    else
                    {
                        _logger.Debug(_IdLog + "No se agregó correctamente el IdCartera ");
                        return objReturn.SeleccionarRespuesta(99);
                    }
                }
                catch (Exception ex)
                {
                    _logger.Debug(_IdLog + "No se agrego correctamente el IdCartera  Exception: " + ex.Message);
                    return objReturn.SeleccionarRespuesta(99);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(_IdLog + "InsertarCartera Exception " + ex.Message);
                return objReturn.SeleccionarRespuesta(99);
            }
        }
        public Respuesta ActualizarCartera(CarteraDto ObjActualizar)
        {
            Respuesta objReturn = new Respuesta();
            try
            {
                string objRequestLog = JsonConvert.SerializeObject(ObjActualizar, Formatting.Indented);
                _logger.Debug("--------------------------------------------------------------------");
                _logger.Debug(_IdLog + "Se va a actualizar datos en la tabla Cartera: " + objRequestLog);
                try
                {
                    if (ObjActualizar.IdCartera > 0)
                    {
                        var ObjCarteraBd = _context.Carteras.Find(ObjActualizar.IdCartera);

                        string JsonCarteraBd = JsonConvert.SerializeObject(ObjCarteraBd, Formatting.Indented);

                        _logger.Debug(_IdLog + "DATOS ANTERIORES" + Environment.NewLine + JsonCarteraBd);

                        ObjCarteraBd = (new Model.PasarelaPagos.Cartera
                        {
                            IdComercio = (ObjActualizar.IdComercio>0 && ObjActualizar.IdComercio != ObjCarteraBd.IdComercio) ? ObjActualizar.IdComercio : ObjCarteraBd.IdComercio,
                            IdCliente = (ObjActualizar.IdCliente > 0 && ObjActualizar.IdCliente != ObjCarteraBd.IdCliente) ? ObjActualizar.IdCliente : ObjCarteraBd.IdCliente,
                            Descripcion = ( !String.IsNullOrEmpty(ObjActualizar.Descripcion) && ObjActualizar.Descripcion != ObjCarteraBd.Descripcion) ? ObjActualizar.Descripcion : ObjCarteraBd.Descripcion,
                            FechaInicio = (ObjActualizar.FechaInicio != DateTime.MinValue && ObjActualizar.FechaInicio != ObjCarteraBd.FechaInicio) ? ObjActualizar.FechaInicio : ObjCarteraBd.FechaInicio,
                            FechaFin = (ObjActualizar.FechaFin != DateTime.MinValue && ObjActualizar.FechaFin != ObjCarteraBd.FechaFin) ? ObjActualizar.FechaFin : ObjCarteraBd.FechaFin,
                            Valor = (ObjActualizar.Valor > 0 && ObjActualizar.Valor != ObjCarteraBd.Valor) ? ObjActualizar.Valor : ObjCarteraBd.Valor,
                        });
                        _logger.Debug("---------------------------------------------");
                        JsonCarteraBd = JsonConvert.SerializeObject(ObjCarteraBd, Formatting.Indented);

                        _logger.Debug(_IdLog + "DATOS NUEVOS" + Environment.NewLine + JsonCarteraBd);

                        try
                        {
                            _context.Entry(ObjCarteraBd).State = EntityState.Modified;

                            _context.SaveChanges();
                            if (ObjCarteraBd.IdCartera > 0)
                            {
                                _logger.Debug(_IdLog + "Se actualizó correctamente el IdCartera " + ObjCarteraBd.IdCartera);
                                return objReturn.SeleccionarRespuesta(1, ObjCarteraBd.IdCartera);

                            }
                            else
                            {
                                _logger.Debug(_IdLog + "No se actualizó correctamente el IdCartera " + ObjActualizar.IdCartera);
                                return objReturn.SeleccionarRespuesta(99);
                            }
                        }
                        catch (Exception ex)
                        {
                            _logger.Debug(_IdLog + "No se actualizó correctamente el IdCartera " + ObjActualizar.IdCartera + " Exception: " + ex.Message);
                            return objReturn.SeleccionarRespuesta(99);
                        }
                    }
                    else
                    {
                        _logger.Debug(_IdLog + "No se encontro el IdCartera " + ObjActualizar.IdCartera + " en la tabla Cartera, no se pueden actualizar datos.");
                        _logger.Debug("--------------------------------------------------------------------");
                        return objReturn.SeleccionarRespuesta(99);
                    }
                }
                catch (Exception ex)
                {
                    _logger.Debug(_IdLog + "No se agrego correctamente el IdCartera  Exception: " + ex.Message);
                    return objReturn.SeleccionarRespuesta(99);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(_IdLog + "ActualizarCartera Exception " + ex.Message);
                return objReturn.SeleccionarRespuesta(99);
            }
        }
        public Respuesta EliminarCartera(int IdCartera)
        {
            Respuesta objReturn = new Respuesta();
            try
            {
                string objRequestLog = JsonConvert.SerializeObject(IdCartera, Formatting.Indented);
                _logger.Debug("--------------------------------------------------------------------");
                _logger.Debug(_IdLog + "Se va a eliminar datos en la tabla Cartera: " + objRequestLog);
                try
                {
                    if (IdCartera > 0)
                    {
                        var ObjCarteraBd = _context.Carteras.Find(IdCartera);

                        string JsonCarteraBd = JsonConvert.SerializeObject(ObjCarteraBd, Formatting.Indented);

                        _logger.Debug(_IdLog + "DATOS A ELIMINAR" + Environment.NewLine + JsonCarteraBd);

                        try
                        {
                            _context.Remove(ObjCarteraBd);
                            _context.SaveChanges();
                            _logger.Debug($"{_IdLog} Se elimino correctamente el IdCartera: {IdCartera}");
                            return objReturn.SeleccionarRespuesta(1, ObjCarteraBd.IdCartera);
                        }
                        catch (Exception ex)
                        {
                            _logger.Debug($"{_IdLog} No se eliminó correctamente el IdCartera: {IdCartera} Exception: {ex.Message}");
                            return objReturn.SeleccionarRespuesta(99);
                        }
                    }
                    else
                    {
                        _logger.Debug(_IdLog + "No se encontro el IdCartera " + IdCartera + " en la tabla Cartera, no se pueden ELIMINAR datos.");
                        _logger.Debug("--------------------------------------------------------------------");
                        return objReturn.SeleccionarRespuesta(99);
                    }
                }
                catch (Exception ex)
                {
                    _logger.Debug(_IdLog + "No se agrego correctamente el IdCartera  Exception: " + ex.Message);
                    return objReturn.SeleccionarRespuesta(99);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(_IdLog + "EliminarCartera Exception " + ex.Message);
                return objReturn.SeleccionarRespuesta(99);
            }
        }
    }
}

namespace DataAccess.Data.PasarelaPagos
{
    public class CarteraDto
    {
        public int IdCartera { get; set; }
        public int? IdComercio { get; set; }
        public int? IdCliente { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
