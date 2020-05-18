using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HogarIoT
{
    class HogarIoTContext : DbContext
    {
        DbSet<Dispositivo> Dispositivos { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;DataBase=HogarIoTDB;Trusted_Connection=true");
        }
    }
}
