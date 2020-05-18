﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HogarIoT
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Creacion
            Usuario usuario = new Usuario();

            Heladera heladera1 = new Heladera();
            Luz luz1 = new Luz();
            Camara camara1 = new Camara();
            AireAcondicionado AA1 = new AireAcondicionado();

            //Inicializacion
            usuario.NombreUsuario = "juan.fernandez";
            usuario.Contrasenia = "Juan2020";
            usuario.Dispositivos = new List<Dispositivo>();

            heladera1.Nombre = "Heladera cocina";
            heladera1.TempFreezer = -5;
            usuario.Dispositivos.Add(heladera1);

            luz1.Nombre = "Luz puerta entrada";
            luz1.CambiarEstado(Estado.SIN_CONEXION);
            usuario.Dispositivos.Add(luz1);

            camara1.Id = 3;
            camara1.Grabar = true;
            usuario.Dispositivos.Add(camara1);

            AA1.Mode = Modo.CALOR;
            AA1.temperatura = 27;
            usuario.Dispositivos.Add(AA1);

            //Mostrar
            Console.WriteLine(usuario.NombreUsuario);
            Console.WriteLine(usuario.Dispositivos.ElementAt(0).Nombre);
        }
    }
}
