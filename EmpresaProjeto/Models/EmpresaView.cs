namespace EmpresaProjeto.Models
{
    public class EmpresaView
    {
        public Guid Id { get; set; }

        public string? NomeEmpresa { get; set; }

        public string? Cnpj { get; set; }


        public string? Setor { get; set; }

        public string? CidadeModalidade { get; set; }

        public int Status { get; set; }
    }
}
