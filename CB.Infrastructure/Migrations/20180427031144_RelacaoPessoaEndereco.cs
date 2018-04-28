using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CB.Infrastructure.Migrations
{
    public partial class RelacaoPessoaEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Enderecos_EnderecoId",
                table: "Pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas");

            migrationBuilder.DropIndex(
                name: "IX_Pessoas_EnderecoId",
                table: "Pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "Pessoa");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Conta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa",
                column: "PessoaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conta",
                table: "Conta",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_EnderecoId",
                table: "Pessoa",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Enderecos_EnderecoId",
                table: "Pessoa",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Enderecos_EnderecoId",
                table: "Pessoa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_EnderecoId",
                table: "Pessoa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conta",
                table: "Conta");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                newName: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Conta",
                newName: "Cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas",
                column: "PessoaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_EnderecoId",
                table: "Pessoas",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Enderecos_EnderecoId",
                table: "Pessoas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
