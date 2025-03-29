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

        #region OBTENER LISTADO DE CATEGORIAS
        public async Task<IEnumerable<CategoriaActivosModel>> ObtenerListadoCategoriasActivos()
        {
            return await _context.CategoriasActivos.ToListAsync();
        }
        #endregion

        #region OBTENER CATEGORÍA POR ID

        public async Task<CategoriaActivosModel> ObtenerCategoriaActivosPorId(int id)
        {
            return await _context.CategoriasActivos.FindAsync(id);
        }
        #endregion

        #region CREAR CATEGORÍA DE ACTIVOS
        public async Task CrearCategoriaActivos(CategoriaActivosModel categoria)
        {
            await _context.CategoriasActivos.AddAsync(categoria);
            await _context.SaveChangesAsync();
            
        }
        #endregion



    }
}
