namespace ApiRest.DAO
{
    public class Respuesta
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public int Identidad { get; set; }

        public Respuesta SeleccionarRespuesta(int code,int identidad = 99)
        {
            Respuesta objReturn = new();
            objReturn.Code=code;
            objReturn.Identidad = identidad;
            switch (code)
            {
                case 1:
                    objReturn.Description = "Exitoso";
                    break;
                case 99:
                    objReturn.Description = "Fallido";
                    break;
                default:
                    objReturn.Code = 99;
                    objReturn.Description = "Fallido";
                    break;
            }

            return objReturn;
        }
    }
}
