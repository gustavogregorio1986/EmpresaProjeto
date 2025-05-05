using EmpresaProjeto.Dominio.Dominio;

namespace EmpresaProjeto.Models
{
    public class IndexView
    {
        public List<Empresa> Empresas { get; set; } = new();
        public int TotalItens { get; set; }
        public int PaginaAtual { get; set; }
        public int ItensPorPagina { get; set; }

        public int TotalPaginas => (int)Math.Ceiling((double)TotalItens / ItensPorPagina);
    }
}
