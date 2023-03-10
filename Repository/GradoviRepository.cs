using AutoMapper;
using Hp.Data;
using Hp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GradoviRepository : IGradoviRepository
    {
        private readonly HpContext _context;


        public GradoviRepository(HpContext context, IMapper mapper)
        {
            _context = context;

        }



        public async Task<IEnumerable<SifrarnikGradovaZaPbr>> GetAllGradovi()
        {
            try
            {
                return await _context.SifrarnikGradovaZaPbrs.ToListAsync();
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
                return await _context.SifrarnikGradovaZaPbrs.FirstOrDefaultAsync(s => s.Id == id);
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
                await _context.SifrarnikGradovaZaPbrs.AddAsync(grad);
                await _context.SaveChangesAsync();
                return grad;
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
                SifrarnikGradovaZaPbr gradDb = await _context.SifrarnikGradovaZaPbrs.FirstOrDefaultAsync(g => g.Id == updatedGrad.Id);

                gradDb.Pbr = updatedGrad.Pbr;
                gradDb.Naziv = updatedGrad.Naziv;
                gradDb.Zupanija = updatedGrad.Zupanija;

                _context.SifrarnikGradovaZaPbrs.Update(gradDb);
                await _context.SaveChangesAsync();
                return gradDb;
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
                var gradDb = await _context.SifrarnikGradovaZaPbrs.FirstOrDefaultAsync(g => g.Id == updatedGrad.Id);
                if (gradDb != null)
                {
                    gradDb.Pbr = updatedGrad.Pbr;
                    gradDb.Naziv = updatedGrad.Naziv;
                    gradDb.Zupanija = updatedGrad.Zupanija;

                    await _context.SaveChangesAsync();
                }

                return gradDb;
            }
            catch
            {
                return null;
            }
        }


        //public async Task DeleteGrad(int id)
        //{
        //    var grad = await GetGradById(id);
        //    if (grad != null)
        //    {
        //        _context.SifrarnikGradovaZaPbrs.Remove(grad);
        //        await _context.SaveChangesAsync();
        //    }
        //}


        public async Task DeleteGrad(SifrarnikGradovaZaPbr grad)
        {
            _context.SifrarnikGradovaZaPbrs.Remove(grad);
            await _context.SaveChangesAsync();
        }

    }
}
