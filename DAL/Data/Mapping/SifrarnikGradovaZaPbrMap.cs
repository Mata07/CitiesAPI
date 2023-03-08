using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hp.Data.Mapping
{
    public partial class SifrarnikGradovaZaPbrMap
        : IEntityTypeConfiguration<Hp.Data.Entities.SifrarnikGradovaZaPbr>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Hp.Data.Entities.SifrarnikGradovaZaPbr> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SIFRARNIK_GRADOVA_ZA_PBR", "dbo");

            // key
            //builder.HasNoKey();
            //builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                //.IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int");
                //.ValueGeneratedOnAdd();

            builder.Property(t => t.Pbr)
                .HasColumnName("PBR")
                .HasColumnType("int");

            builder.Property(t => t.Naziv)
                .HasColumnName("NAZIV")
                .HasColumnType("nvarchar(512)")
                .HasMaxLength(512);

            builder.Property(t => t.Zupanija)
                .HasColumnName("ZUPANIJA")
                .HasColumnType("nvarchar(512)")
                .HasMaxLength(512);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "SIFRARNIK_GRADOVA_ZA_PBR";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string Pbr = "PBR";
            public const string Naziv = "NAZIV";
            public const string Zupanija = "ZUPANIJA";
        }
        #endregion
    }
}
