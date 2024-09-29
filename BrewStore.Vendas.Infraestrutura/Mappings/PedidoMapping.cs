using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BrewStore.Vendas.Dominio;

namespace BrewStore.Vendas.Infraestrutura.Mappings
{
    public class PedidoMapping : IEntityTypeConfiguration<PedidoDominio>
    {
        public void Configure(EntityTypeBuilder<PedidoDominio> builder)
        {
            builder.HasKey(c => c.Id);

            
            builder.HasMany(p => p.PedidoItems)
                .WithOne(p => p.Pedido)
                .HasForeignKey(p => p.IdPedido);

            builder.Property(c => c.IdCliente)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.IdCliente)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.IdSituacao)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.Data)
                .IsRequired()
                .HasColumnType("Date");

            builder.Property(c => c.ValorTotal)
                .HasColumnType("numeric(12, 2)");

            builder.ToTable("Pedidos");
        }
    }
}
