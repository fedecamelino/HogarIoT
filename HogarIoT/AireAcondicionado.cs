using System;
using System.Collections.Generic;
using System.Text;

namespace HogarIoT
{
    public class AireAcondicionado : Dispositivo
    {
        public int Temperatura { get; set; }
        public Modo Modo { get; set; }

        public void CambiarModo (TipoModo modo)
        {
            this.Modo.DescripcionModo = modo;
        }
    }
}
