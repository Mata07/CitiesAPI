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

        public async Task<SifrarnikGradovaZaPbr> UpdateGrad(SifrarnikGradovaZaPbr updatedGrad)
        {
            try
            {
                return await _gradoviRepository.UpdateGrad(updatedGrad);
            }
            catch
            {
                return null;
            }
        }

        public async Task<SifrarnikGradovaZaPbr> UpdateGradById(int id, SifrarnikGradovaZaPbr updatedGrad)
        {
            try
            {
                return await _gradoviRepository.UpdateGradById(id, updatedGrad);
            }
            catch
            {
                return null;
            }
        }

        //public async Task DeleteGrad(int id)
        //{
        //   await _gradoviRepository.DeleteGrad(id);
        //}

        public async Task DeleteGrad(SifrarnikGradovaZaPbr grad)
        {
            await _gradoviRepository.DeleteGrad(grad);
        }



    }
}
