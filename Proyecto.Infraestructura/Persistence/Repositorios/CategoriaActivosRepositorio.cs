using Microsoft.EntityFrameworkCore;
using Proyecto.Core.Entidades;
using Proyecto.Core.Interfaces;
using Proyecto.Infraestructura.Persistence.DataAccess;

namespace Proyecto.Infraestructura.Persistence.Repositorios
{
    public class CategoriaActivosRepositorio : ICategoriaActivosRepositorio
    {
        // importar ApplicationDbContext

        private readonly ApplicationDbContext _context; 

        // Constructor
        public CategoriaActivosRepositorio(ApplicationDbContext context) { 
            _context = context;
        }
        
        public async Task<IEnumerable<CategoriaActivosModel>> ObtenerListadoCategoriasActivos()
        {
            return await _context.CategoriasActivos.ToListAsync();
        }
    }
}
