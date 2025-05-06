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
    public class MensagemMap : IEntityTypeConfiguration<Mensagem>
    {
        public void Configure(EntityTypeBuilder<Mensagem> builder)
        {
            builder.ToTable("tb_Mengsame");

            builder.HasKey(m => m.Id);


            builder.Property(m => m.NomePessoa)
                .IsRequired()
                .HasColumnType("NVARCHAR(50)");

            builder.Property(m => m.Assunto)
                .IsRequired()
                .HasColumnType("NVARCHAR(50)");

            builder.Property(m => m.Descricao)
                .IsRequired()
                .HasColumnType("NVARCHAR(50)");
        }
    }
}
