using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Core.Entidades;

namespace Proyecto.Core.Interfaces
{
    public interface ICategoriaActivosRepositorio
    {
        Task CrearCategoriaActivos(CategoriaActivosModel categoria);
        Task<CategoriaActivosModel> ObtenerCategoriaActivosPorId(int id);
        Task<IEnumerable<CategoriaActivosModel>> ObtenerListadoCategoriasActivos();
    }
}
