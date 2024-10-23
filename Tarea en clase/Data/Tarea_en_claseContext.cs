using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarea_en_clase.Models;

namespace Tarea_en_clase.Data
{
    public class Tarea_en_claseContext : DbContext
    {
        public Tarea_en_claseContext (DbContextOptions<Tarea_en_claseContext> options)
            : base(options)
        {
        }

        public DbSet<Tarea_en_clase.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<Tarea_en_clase.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<Tarea_en_clase.Models.Jugadores> Jugadores { get; set; } = default!;
    }
}
