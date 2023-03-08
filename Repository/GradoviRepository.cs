using AutoMapper;
using Hp.Data;
using Hp.Data.Entities;
using Hp.Domain.Models;
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
        private readonly IMapper _mapper;

        public GradoviRepository(HpContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

        public async Task<SifrarnikGradovaZaPbr> CreateGrad(SifrarnikGradovaZaPbrCreateModel grad)
        {
            try
            {
                //var gradoviDb = await _context.SifrarnikGradovaZaPbrs.ToListAsync();
                //var gradDb = gradoviDb.Last();
                //grad.Id = gradDb.Id + 1;
                //await _context.SifrarnikGradovaZaPbrs.AddAsync(grad);
                //await _context.SaveChangesAsync();
                //return grad;
                var gradoviDb = await _context.SifrarnikGradovaZaPbrs.ToListAsync();
                var gradDb = gradoviDb.Last();
                //grad.Id = gradDb.Id + 1;
                var grad2 = _mapper.Map<SifrarnikGradovaZaPbr>(grad);
                //grad2.Id = gradDb.Id + 1; 
                await _context.SifrarnikGradovaZaPbrs.AddAsync(grad2);
                await _context.SaveChangesAsync();
                return grad2;
            }
            catch
            {
                return null;
            }
        }

        public Task<SifrarnikGradovaZaPbr> UpdateGrad(SifrarnikGradovaZaPbr grad)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGrad(int id)
        {
            throw new NotImplementedException();
        }

    }
}
