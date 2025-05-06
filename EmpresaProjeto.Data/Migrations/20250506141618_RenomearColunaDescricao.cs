using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaProjeto.Data.Migrations
{
    public partial class RenomearColunaDescricao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descircao",
                table: "Mensagens",
                newName: "Desricao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desricao",
                table: "Mensagens",
                newName: "Descircao");
        }
    }
}
