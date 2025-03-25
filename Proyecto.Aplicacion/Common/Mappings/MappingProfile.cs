using AutoMapper;
using Proyecto.Core.DTOs;
using Proyecto.Core.Entidades;

namespace Proyecto.Aplicacion.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<CategoriaActivosModel, CategoriaActivosDTO>();
            CreateMap<CategoriaActivosDTO, CategoriaActivosDTO>();
        }
    }
}
