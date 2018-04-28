using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CB.Infrastructure.Migrations
{
    public partial class manyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContaId",
                table: "Movimentacoes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoContaId",
                table: "Conta",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContaPessoa",
                columns: table => new
                {
                    ContaId = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaPessoa", x => new { x.ContaId, x.PessoaId });
                    table.ForeignKey(
                        name: "FK_ContaPessoa_Conta_ContaId",
                        column: x => x.ContaId,
                        principalTable: "Conta",
                        principalColumn: "ContaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContaPessoa_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacoes_ContaId",
                table: "Movimentacoes",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_Conta_TipoContaId",
                table: "Conta",
                column: "TipoContaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContaPessoa_PessoaId",
                table: "ContaPessoa",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_TipoContas_TipoContaId",
                table: "Conta",
                column: "TipoContaId",
                principalTable: "TipoContas",
                principalColumn: "TipoContaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacoes_Conta_ContaId",
                table: "Movimentacoes",
                column: "ContaId",
                principalTable: "Conta",
                principalColumn: "ContaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conta_TipoContas_TipoContaId",
                table: "Conta");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacoes_Conta_ContaId",
                table: "Movimentacoes");

            migrationBuilder.DropTable(
                name: "ContaPessoa");

            migrationBuilder.DropIndex(
                name: "IX_Movimentacoes_ContaId",
                table: "Movimentacoes");

            migrationBuilder.DropIndex(
                name: "IX_Conta_TipoContaId",
                table: "Conta");

            migrationBuilder.DropColumn(
                name: "ContaId",
                table: "Movimentacoes");

            migrationBuilder.DropColumn(
                name: "TipoContaId",
                table: "Conta");
        }
    }
}
