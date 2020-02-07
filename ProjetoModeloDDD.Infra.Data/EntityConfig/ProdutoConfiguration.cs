using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);


            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Valor)
                .IsRequired();

            HasRequired(p => p.Cliente)
                  .WithMany()
                  .HasForeignKey(p => p.ClienteId);
        }
    }
}
