using AutoMapper;
using Proyecto.Aplicacion.Interfaces;
using Proyecto.Core.DTOs;
using Proyecto.Core.Entidades;
using Proyecto.Core.Interfaces;

namespace Proyecto.Aplicacion.Services
{
    public class ActivosService : IActivosService
    {
        private readonly ICategoriaActivosRepositorio _categoriaActivosRepositorio;
        private readonly IMapper _mapper;
            
        public ActivosService(ICategoriaActivosRepositorio categoriaActivosRepositorio, IMapper mapper)
        {
            _categoriaActivosRepositorio = categoriaActivosRepositorio;
            _mapper = mapper;
        }

        #region Convertir Modelo a DTO

        public CategoriaActivosModel ConvertToModel(CategoriaActivosDTO dto)
        {
            return _mapper.Map<CategoriaActivosModel>(dto);
        }

        #endregion


        #region Convertir DTOs a Modelo

        public CategoriaActivosDTO ConvertToDTO(CategoriaActivosModel model)
        {
            return _mapper.Map<CategoriaActivosDTO>(model);
        }

        #endregion

        #region

        public async Task<IEnumerable<CategoriaActivosModel>> ObtenerListadoCategoriasActivos()
        {
            var listadoCategoriasActivos = await _categoriaActivosRepositorio.ObtenerListadoCategoriasActivos();
            return listadoCategoriasActivos;
        }

        #endregion

    }
}
