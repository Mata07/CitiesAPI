using AutoMapper;
using Hp.Data.Entities;
using Hp.Domain.Models;

namespace CityApi.AutoMapper
{
    public class ControllerMappingService : IControllerMappingService
    {
        public IMapper mapper;
        public ControllerMappingService()
        {
            var config = new MapperConfiguration
                (cfg =>
                {
                    cfg.CreateMap<SifrarnikGradovaZaPbr, SifrarnikGradovaZaPbrReadModel>();

                    cfg.CreateMap<SifrarnikGradovaZaPbrCreateModel, SifrarnikGradovaZaPbr>();

                    cfg.CreateMap<SifrarnikGradovaZaPbr, SifrarnikGradovaZaPbrUpdateModel>();

                    cfg.CreateMap<SifrarnikGradovaZaPbrUpdateModel, SifrarnikGradovaZaPbr>();

                    cfg.CreateMap<SifrarnikGradovaZaPbrReadModel, SifrarnikGradovaZaPbrUpdateModel>();

                    cfg.CreateMap<SifrarnikGradovaZaPbrCreateModel, SifrarnikGradovaZaPbrReadModel>();
                });
            mapper = new Mapper(config);
        }

        public TDestination Map<TDestination>(object source)
        {
            return mapper.Map<TDestination>(source);
        }
    }
}

