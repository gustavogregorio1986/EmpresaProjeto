using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaProjeto.Data.Migrations
{
    public partial class RenomearDescricao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desricao",
                table: "Mensagens",
                newName: "Descricao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Mensagens",
                newName: "Desricao");
        }
    }
}
