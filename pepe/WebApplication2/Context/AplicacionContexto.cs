using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using WebApplication2.Modelss;
using WebApplication2.Modelsss;

namespace WebApplication2.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Estudiante> estudiante { get; set; }
        public DbSet<Docente> docente { get; set; }
        public DbSet<Universidad> universidad { get; set; }
    }
}
