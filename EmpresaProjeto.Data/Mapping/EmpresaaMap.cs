using EmpresaProjeto.Dominio.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaProjeto.Data.Mapping
{
    public class EmpresaaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("tb_Empresa");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomeEmpresa)
                .IsRequired()
                .HasColumnType("NVARCHAR(40)");

            builder.Property(x => x.Setor)
                .IsRequired()
                .HasColumnType("NVARCHAR(15)");

            builder.Property(x => x.Setor)
                .IsRequired()
                .HasColumnType("NVARCHAR(50)");

            builder.Property(x => x.CidadeModalidade)
                .IsRequired()
                .HasColumnType("NVARCHAR(40)");

            builder.Property(x => x.Status)
                .IsRequired()
                .HasColumnType("INT");


        }
    }
}
