using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ER_Ejercicio2tablas.Models;

namespace ER_Ejercicio2tablas.Data
{
    public class ER_Ejercicio2DbContext : DbContext
    {
        public ER_Ejercicio2DbContext (DbContextOptions<ER_Ejercicio2DbContext> options)
            : base(options)
        {
        }

        public DbSet<ER_Ejercicio2tablas.Models.Burger> Burger { get; set; } = default!;

        public DbSet<ER_Ejercicio2tablas.Models.Promo>? Promo { get; set; }
    }
}
