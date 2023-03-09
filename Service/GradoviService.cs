using Hp.Data.Entities;
using Hp.Domain.Models;
using Repository;
using Repository.Common;
using Service.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class GradoviService : IGradoviService
    {
        private readonly IGradoviRepository _gradoviRepository;

        public GradoviService(IGradoviRepository gradoviRepository)
        {
            _gradoviRepository = gradoviRepository;
        }


        public async Task<IEnumerable<SifrarnikGradovaZaPbr>> GetAllGradovi()
        {
            try
            {
                return await _gradoviRepository.GetAllGradovi();
            }
            catch
            {
                return null;
            }
        }

        public async Task<SifrarnikGradovaZaPbr> GetGradById(int id)
        {
            try
            {
                return await _gradoviRepository.GetGradById(id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<SifrarnikGradovaZaPbr> CreateGrad(SifrarnikGradovaZaPbr grad)
        {
            try
            {
                return await _gradoviRepository.CreateGrad(grad);
            }
            catch
            {
                return null;
            }
        }




    }
}
