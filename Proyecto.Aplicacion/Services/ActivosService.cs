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

        #region CONVERTIR MODELO A DTO

        public CategoriaActivosModel ConvertToModel(CategoriaActivosDTO dto)
        {
            return _mapper.Map<CategoriaActivosModel>(dto);
        }

        #endregion


        #region CONVERTIR DTO A MODELO

        public CategoriaActivosDTO ConvertToDTO(CategoriaActivosModel model)
        {
            return _mapper.Map<CategoriaActivosDTO>(model);
        }

        #endregion

        #region OBTENER LISTADO

        public async Task<IEnumerable<CategoriaActivosModel>> ObtenerListadoCategoriasActivos()
        {
            var listadoCategoriasActivos = await _categoriaActivosRepositorio.ObtenerListadoCategoriasActivos();
            return listadoCategoriasActivos;
        }

        #endregion

        #region OBTENER ID 

        public async Task<CategoriaActivosModel> ObtenerCategoriaActivoPorIdAsync(int id)
        {
            var categoria = await _categoriaActivosRepositorio.ObtenerCategoriaActivosPorId(id);
            return categoria;
        }

        #endregion

        #region CREAR CATEGORÍA

        public async Task<CategoriaActivosModel> CrearCategoriaAsync(CategoriaActivosModel model)
        {
            await _categoriaActivosRepositorio.CrearCategoriaActivos(model);
            var categoriaId = model.Id;
            var categoriaCreado = await ObtenerCategoriaActivoPorIdAsync(categoriaId);
            return categoriaCreado;

        }

        #endregion
    }
}
