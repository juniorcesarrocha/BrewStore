using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrewStore.Catalogo.Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class CatalogoDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(500)", nullable: false),
                    Valor = table.Column<decimal>(type: "numeric(12, 2)", nullable: false),
                    QuantidadeEstoque = table.Column<int>(type: "int", nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false),
                    QuantidadeMinimaDesconto = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ValorDescontoQuantidade = table.Column<decimal>(type: "numeric(12, 2)", nullable: true, defaultValue: 0m),
                    DataDescontoSazonal = table.Column<DateTime>(type: "date", nullable: true),
                    PercentualDescontoSazonal = table.Column<decimal>(type: "numeric(12, 2)", nullable: true, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
