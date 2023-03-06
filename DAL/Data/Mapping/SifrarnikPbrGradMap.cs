using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Hp.Data.Mapping
{
    public partial class SifrarnikPbrGradMap
        : IEntityTypeConfiguration<Hp.Data.Entities.SifrarnikPbrGrad>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Hp.Data.Entities.SifrarnikPbrGrad> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("SIFRARNIK_PBR_GRAD", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.PbrGradId)
                .IsRequired()
                .HasColumnName("PBR_GRAD_ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Pbr)
                .HasColumnName("PBR")
                .HasColumnType("int");

            builder.Property(t => t.NazivPu)
                .HasColumnName("NAZIV_PU")
                .HasColumnType("nvarchar(512)")
                .HasMaxLength(512);

            builder.Property(t => t.AdresaPu)
                .HasColumnName("ADRESA_PU")
                .HasColumnType("nvarchar(512)")
                .HasMaxLength(512);

            builder.Property(t => t.Mjesto)
                .HasColumnName("MJESTO")
                .HasColumnType("nvarchar(512)")
                .HasMaxLength(512);

            builder.Property(t => t.Grad)
                .HasColumnName("GRAD")
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
            public const string Name = "SIFRARNIK_PBR_GRAD";
        }

        public struct Columns
        {
            public const string PbrGradId = "PBR_GRAD_ID";
            public const string Pbr = "PBR";
            public const string NazivPu = "NAZIV_PU";
            public const string AdresaPu = "ADRESA_PU";
            public const string Mjesto = "MJESTO";
            public const string Grad = "GRAD";
            public const string Zupanija = "ZUPANIJA";
        }
        #endregion
    }
}
