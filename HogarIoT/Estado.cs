using System;
using System.Collections.Generic;
using System.Text;

namespace HogarIoT
{
    public class Estado
    {
        public int EstadoID { get; set; }
        public TipoEstado DescripcionEstado { get; set; }
    }

    public enum TipoEstado
    {
        ENCENDIDO, APAGADO, SIN_CONEXION
    }
}
