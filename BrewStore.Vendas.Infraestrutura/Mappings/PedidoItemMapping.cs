using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BrewStore.Vendas.Dominio;

namespace BrewStore.Vendas.Infraestrutura.Mappings
{
    public class PedidoItemMapping : IEntityTypeConfiguration<PedidoItemDominio>
    {
        public void Configure(EntityTypeBuilder<PedidoItemDominio> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Pedido)
                .WithMany(c => c.PedidoItems);

            builder.Property(c => c.IdPedido)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.IdProduto)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.Quantidade)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.ValorUnitario)
                .IsRequired()
                .HasColumnType("numeric(12, 2)");

            builder.ToTable("PedidoItems");
        }
    }
}
