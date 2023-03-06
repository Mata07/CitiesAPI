using System;
using AutoMapper;
using Hp.Data.Entities;
using Hp.Domain.Models;

namespace Hp.Domain.Mapping
{
    public partial class SifrarnikPbrNaseljeProfile
        : AutoMapper.Profile
    {
        public SifrarnikPbrNaseljeProfile()
        {
            CreateMap<Hp.Data.Entities.SifrarnikPbrNaselje, Hp.Domain.Models.SifrarnikPbrNaseljeReadModel>();

            CreateMap<Hp.Domain.Models.SifrarnikPbrNaseljeCreateModel, Hp.Data.Entities.SifrarnikPbrNaselje>();

            CreateMap<Hp.Data.Entities.SifrarnikPbrNaselje, Hp.Domain.Models.SifrarnikPbrNaseljeUpdateModel>();

            CreateMap<Hp.Domain.Models.SifrarnikPbrNaseljeUpdateModel, Hp.Data.Entities.SifrarnikPbrNaselje>();

            CreateMap<Hp.Domain.Models.SifrarnikPbrNaseljeReadModel, Hp.Domain.Models.SifrarnikPbrNaseljeUpdateModel>();

        }

    }
}
