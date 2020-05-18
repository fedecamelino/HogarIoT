using System;
using System.Collections.Generic;
using System.Text;

namespace HogarIoT
{
    class Usuario
    {
        public string NombreUsario { get; set; }
        public string Contrasenia { get; set; }
        public List<Dispositivo> Dispositivos { get; set; }

    }
}
