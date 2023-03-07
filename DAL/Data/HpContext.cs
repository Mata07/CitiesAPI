using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Hp.Data
{
    public partial class HpContext : DbContext
    {
        public HpContext()
        {
            
        }

        public HpContext(DbContextOptions<HpContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<Hp.Data.Entities.SifrarnikGradovaZaPbr> SifrarnikGradovaZaPbrs { get; set; }

        public virtual DbSet<Hp.Data.Entities.SifrarnikPbrGrad> SifrarnikPbrGrads { get; set; }

        public virtual DbSet<Hp.Data.Entities.SifrarnikPbrNaselje> SifrarnikPbrNaseljes { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new Hp.Data.Mapping.SifrarnikGradovaZaPbrMap());
            modelBuilder.ApplyConfiguration(new Hp.Data.Mapping.SifrarnikPbrGradMap());
            modelBuilder.ApplyConfiguration(new Hp.Data.Mapping.SifrarnikPbrNaseljeMap());
            #endregion
        }

    }
}
