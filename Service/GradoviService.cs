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

        public async Task<SifrarnikGradovaZaPbr> AddGrad(SifrarnikGradovaZaPbr grad)
        {
            try
            {
                return await _gradoviRepository.AddGrad(grad);
            }
            catch
            {
                return null;
            }
        }



        public async Task<SifrarnikGradovaZaPbr> UpdateGrad(int id, SifrarnikGradovaZaPbr updatedGrad)
        {
            try
            {
                var gradDb = await _gradoviRepository.GetGradById(id);
                if (gradDb == null)
                {
                    return null;
                }

                gradDb.Pbr = updatedGrad.Pbr;
                gradDb.Naziv = updatedGrad.Naziv;
                gradDb.Zupanija = updatedGrad.Zupanija;

                await _gradoviRepository.UpdateGrad(gradDb);
                return gradDb;
            }
            catch
            {
                return null;
            }
        }

        public async Task<SifrarnikGradovaZaPbr> DeleteGrad(int id)
        {
            try
            {
                var grad = await _gradoviRepository.GetGradById(id);
                if (grad == null)
                {
                    return null;
                }

                _gradoviRepository.DeleteGrad(grad);
                return grad;
            }
            catch 
            {
                return null;
            }
        }

        



    }
}
