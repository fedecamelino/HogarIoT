using System;
using System.Collections.Generic;
using System.Text;

namespace HogarIoT
{
    public class Modo
    {
        public int ModoID { get; set; }
        public TipoModo DescripcionModo { get; set; }
    }

    public enum TipoModo
    {
        AUTO, FRIO, CALOR, VENTILACIÓN
    }
}
