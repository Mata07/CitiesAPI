using AutoMapper;
using Hp.Data.Entities;
using Hp.Domain.Models;

namespace CityApi.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SifrarnikGradovaZaPbr, SifrarnikGradovaZaPbrReadModel>();

            CreateMap<SifrarnikGradovaZaPbrCreateModel, SifrarnikGradovaZaPbr>();

            CreateMap<SifrarnikGradovaZaPbr, SifrarnikGradovaZaPbrUpdateModel>();

            CreateMap<SifrarnikGradovaZaPbrUpdateModel, SifrarnikGradovaZaPbr>();

            CreateMap<SifrarnikGradovaZaPbrReadModel, SifrarnikGradovaZaPbrUpdateModel>();

            CreateMap<SifrarnikGradovaZaPbrCreateModel, SifrarnikGradovaZaPbrReadModel>();
            


        }
    }
}
