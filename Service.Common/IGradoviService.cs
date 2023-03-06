using Hp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Common
{
    public interface IGradoviService
    {
        Task<IEnumerable<SifrarnikGradovaZaPbr>> GetAllGradovi();
        Task<SifrarnikGradovaZaPbr> GetGradById(int id);

    }
}
