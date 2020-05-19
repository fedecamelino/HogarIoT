using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HogarIoT
{
    public class HogarIoTContext : DbContext
    {
        public DbSet<Dispositivo> Dispositivos { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;DataBase=HogarIoTDB3;Trusted_Connection=true");
        }
    }
}
