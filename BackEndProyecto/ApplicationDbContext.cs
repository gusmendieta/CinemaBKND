using BackEndProyecto.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProyecto
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
;
            base.OnModelCreating(modelBuilder); 
        }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
