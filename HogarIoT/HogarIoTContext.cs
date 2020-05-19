using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HogarIoT
{
    public class HogarIoTContext : DbContext
    {
        public DbSet<Dispositivo> Dispositivos { get; set; }
        public DbSet<AireAcondicionado> AA { get; set; }
        public DbSet<Camara> Camaras { get; set; }
        public DbSet<Heladera> Heladeras { get; set; }
        public DbSet<Luz> Luces { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;DataBase=HogarIoTDB4;Trusted_Connection=true");
        }
    }
}
