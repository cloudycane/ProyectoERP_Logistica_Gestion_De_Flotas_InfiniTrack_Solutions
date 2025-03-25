using Proyecto.Core.Entidades;

namespace Proyecto.Aplicacion.Interfaces
{
    public interface IActivosService
    {
        Task<IEnumerable<CategoriaActivosModel>> ObtenerListadoCategoriasActivos();
    }
}
