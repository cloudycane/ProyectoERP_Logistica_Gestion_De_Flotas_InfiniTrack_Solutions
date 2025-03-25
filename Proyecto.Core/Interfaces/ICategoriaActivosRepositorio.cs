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
        Task<IEnumerable<CategoriaActivosModel>> ObtenerListadoCategoriasActivos();
    }
}
