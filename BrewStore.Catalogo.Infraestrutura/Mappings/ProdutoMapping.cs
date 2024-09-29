using BrewStore.Catalogo.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrewStore.Catalogo.Infraestrutura.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<ProdutoDominio>
    {
        public void Configure(EntityTypeBuilder<ProdutoDominio> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(c => c.Valor)
                .IsRequired()
                .HasColumnType("numeric(12, 2)");

            builder.Property(c => c.QuantidadeEstoque)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.Disponivel)
                .IsRequired()
                .HasColumnType("bit");

            builder.Property(c => c.QuantidadeMinimaDesconto)
                .HasColumnType("QuantidadeMinimaDesconto")
                .HasColumnType("int")
                .HasDefaultValue(0);

            builder.Property(c => c.ValorDescontoQuantidade)
                .HasColumnType("ValorDescontoQuantidade")
                .HasColumnType("numeric(12, 2)")
                .HasDefaultValue(0M);

            builder.Property(c => c.DataDescontoSazonal)
                .HasColumnType("DataDescontoSazonal")
                .HasColumnType("date")
                .HasDefaultValue(null);

            builder.Property(c => c.PercentualDescontoSazonal)
                .HasColumnType("PercentualDescontoSazonal")
                .HasColumnType("numeric(12, 2)")
                .HasDefaultValue(0M);


            builder.ToTable("Produtos");
        }
    }
}
