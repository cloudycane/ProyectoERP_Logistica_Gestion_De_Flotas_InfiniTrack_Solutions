using Microsoft.EntityFrameworkCore;
using Proyecto.Core.Entidades;

namespace Proyecto.Infraestructura.Persistence.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<CategoriaActivosModel> CategoriasActivos { get; set; }

    }
}
