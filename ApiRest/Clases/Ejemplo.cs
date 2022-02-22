using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Clases
{
    public class Ejemplo
    {
        public Dto.Respuesta DevolverMensaje (string Mensaje)
        {
            Dto.Respuesta ObjRespuesta = new();
            try
            {
                ObjRespuesta.Mensaje = Mensaje;
            }
            catch (Exception ex)
            {
                ObjRespuesta.Mensaje = ex.Message;
            }
            
            return ObjRespuesta;
        }
    }
    
}
namespace ApiRest.Clases.Dto
{
    public class Respuesta
    {
        public string Mensaje { get; set; }
    }
}
