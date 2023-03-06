using System;
using AutoMapper;
using Hp.Data.Entities;
using Hp.Domain.Models;

namespace Hp.Domain.Mapping
{
    public partial class SifrarnikPbrGradProfile
        : AutoMapper.Profile
    {
        public SifrarnikPbrGradProfile()
        {
            CreateMap<Hp.Data.Entities.SifrarnikPbrGrad, Hp.Domain.Models.SifrarnikPbrGradReadModel>();

            CreateMap<Hp.Domain.Models.SifrarnikPbrGradCreateModel, Hp.Data.Entities.SifrarnikPbrGrad>();

            CreateMap<Hp.Data.Entities.SifrarnikPbrGrad, Hp.Domain.Models.SifrarnikPbrGradUpdateModel>();

            CreateMap<Hp.Domain.Models.SifrarnikPbrGradUpdateModel, Hp.Data.Entities.SifrarnikPbrGrad>();

            CreateMap<Hp.Domain.Models.SifrarnikPbrGradReadModel, Hp.Domain.Models.SifrarnikPbrGradUpdateModel>();

        }

    }
}
