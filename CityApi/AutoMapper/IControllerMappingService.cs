using AutoMapper;
using AutoMapper.Configuration.Conventions;

namespace CityApi.AutoMapper
{
    public interface IControllerMappingService
    {
        public TDestination Map<TDestination>(object source);
    }
}
