using Hp.Data.Entities;
using Hp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Common
{
    public interface IGradoviRepository
    {
        Task<IEnumerable<SifrarnikGradovaZaPbr>> GetAllGradovi(); 
        Task<SifrarnikGradovaZaPbr> GetGradById(int id);
        Task<SifrarnikGradovaZaPbr> CreateGrad(SifrarnikGradovaZaPbr grad);
        Task<SifrarnikGradovaZaPbr> UpdateGrad(SifrarnikGradovaZaPbr grad);
        Task DeleteGrad(int id);
    }
}
