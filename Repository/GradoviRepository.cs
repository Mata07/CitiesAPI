using Hp.Data;
using Hp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Common;
using System;
using System.Collections.Generic;
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
                return await _context.SifrarnikGradovaZaPbrs.FirstOrDefaultAsync(s => s.Id == id);
            }
            catch
            {
                return null;
            }
        }
    }
}
