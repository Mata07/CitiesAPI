using System;
using AutoMapper;
using Hp.Data.Entities;
using Hp.Domain.Models;

namespace Hp.Domain.Mapping
{
    public partial class SifrarnikGradovaZaPbrProfile
        : AutoMapper.Profile
    {
        public SifrarnikGradovaZaPbrProfile()
        {
            CreateMap<SifrarnikGradovaZaPbr, Hp.Domain.Models.SifrarnikGradovaZaPbrReadModel>();

            CreateMap<SifrarnikGradovaZaPbrCreateModel, Hp.Data.Entities.SifrarnikGradovaZaPbr>();

            CreateMap<SifrarnikGradovaZaPbr, Hp.Domain.Models.SifrarnikGradovaZaPbrUpdateModel>();

            CreateMap<SifrarnikGradovaZaPbrUpdateModel, Hp.Data.Entities.SifrarnikGradovaZaPbr>();

            CreateMap<SifrarnikGradovaZaPbrReadModel, Hp.Domain.Models.SifrarnikGradovaZaPbrUpdateModel>();

        }

    }
}
