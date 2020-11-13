using System;
using Entidad;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Tercero> Terceros { get; set; }
        public DbSet<Pago> Pagos { get; set; }
    }
}
