using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrewStore.Catalogo.Infraestrutura.BrewStore.Catalogo.Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class CatalogoRegraDesconto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataDescontoSazonal",
                table: "Produtos",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PercentualDescontoSazonal",
                table: "Produtos",
                type: "numeric(12, 2)",
                nullable: true,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeMinimaDesconto",
                table: "Produtos",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorDescontoQuantidade",
                table: "Produtos",
                type: "numeric(12, 2)",
                nullable: true,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataDescontoSazonal",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "PercentualDescontoSazonal",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "QuantidadeMinimaDesconto",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ValorDescontoQuantidade",
                table: "Produtos");
        }
    }
}
