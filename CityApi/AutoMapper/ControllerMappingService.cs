using AutoMapper;
using Hp.Data.Entities;
using Hp.Domain.Models;

namespace CityApi.AutoMapper
{
    public class ControllerMappingService : Profile, IControllerMappingService
    {
        public Mapper mapper;
        public ControllerMappingService()
        {
            var config = new MapperConfiguration
                (cfg =>
                {
                    cfg.CreateMap<SifrarnikGradovaZaPbr, SifrarnikGradovaZaPbrReadModel>();
                });
            mapper = new Mapper(config);
        }

        public TDestination Map<TDestination>(object source)
        {
            return mapper.Map<TDestination>(source);
        }
    }
}
