using EmpresaProjeto.Dominio.Dominio;
using System.ComponentModel.DataAnnotations;

namespace EmpresaProjeto.Models
{
    public class IndexView
    {
        public List<Empresa> Empresas { get; set; } = new();

        public List<Mensagem> Mensagens { get; set; } = new(); // ✅ PRECISA disso

        public MensagemView MensagemView { get; set; }
        public int TotalItens { get; set; }
        public int PaginaAtual { get; set; }
        public int ItensPorPagina { get; set; }

        public int TotalPaginas => (int)Math.Ceiling((double)TotalItens / ItensPorPagina);

        [Display(Name = "Nome da Pessoa")]
        public string? NomePessoa { get; set; }

        public string? Assunto { get; set; }

        public string? Descricao { get; set; }
    }
}
