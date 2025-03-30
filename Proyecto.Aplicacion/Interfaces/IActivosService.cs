using Proyecto.Core.Entidades;

namespace Proyecto.Aplicacion.Interfaces
{
    public interface IActivosService
    {
        Task<CategoriaActivosModel> CrearCategoriaAsync(CategoriaActivosModel model);
        Task<IEnumerable<CategoriaActivosModel>> ObtenerListadoCategoriasActivos();
    }
}
