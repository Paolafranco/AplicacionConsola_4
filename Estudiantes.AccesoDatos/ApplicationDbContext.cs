using Microsoft.EntityFrameworkCore;
using Estudiantes.Entidad;

namespace Estudiantes.AccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
