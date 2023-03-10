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


        public GradoviRepository(HpContext context)
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
                return await _context.SifrarnikGradovaZaPbrs.FindAsync(id);
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
                _context.Entry(updatedGrad).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return updatedGrad;
            }
            catch
            {
                return null;
            }
        }


        public async void DeleteGrad(SifrarnikGradovaZaPbr grad)
        {
            try
            {
                _context.SifrarnikGradovaZaPbrs.Remove(grad);
                await _context.SaveChangesAsync();
            }
            catch
            {
                return;
            }
        }

    }
}
