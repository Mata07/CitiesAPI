using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hp.Data.Mapping
{
    public partial class SifrarnikPbrNaseljeMap
        : IEntityTypeConfiguration<Hp.Data.Entities.SifrarnikPbrNaselje>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Hp.Data.Entities.SifrarnikPbrNaselje> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SIFRARNIK_PBR_NASELJE", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.PbrNaseljeId)
                .IsRequired()
                .HasColumnName("PBR_NASELJE_ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Pbr)
                .HasColumnName("PBR")
                .HasColumnType("int");

            builder.Property(t => t.Naselje)
                .HasColumnName("NASELJE")
                .HasColumnType("nvarchar(512)")
                .HasMaxLength(512);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SIFRARNIK_PBR_NASELJE";
        }

        public struct Columns
        {
            public const string PbrNaseljeId = "PBR_NASELJE_ID";
            public const string Pbr = "PBR";
            public const string Naselje = "NASELJE";
        }
        #endregion
    }
}
