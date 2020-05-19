using System;
using System.Collections.Generic;
using System.Text;

namespace HogarIoT
{
    public class Dispositivo
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public Estado Estado { get; set; }

        public void CambiarEstado (Estado estado)
        {
            this.Estado = estado;
        }
    }
}

