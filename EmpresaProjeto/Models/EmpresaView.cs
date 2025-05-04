using System.ComponentModel.DataAnnotations;

namespace EmpresaProjeto.Models
{
    public class EmpresaView
    {
        public Guid Id { get; set; }

        [Display(Name = "Nome da Empresa")]
        [Required(ErrorMessage = "Informe o Nome da Empresa")]
        public string? NomeEmpresa { get; set; }

        [Required(ErrorMessage = "Informe o Cnpj")]
        public string? Cnpj { get; set; }

        [Required(ErrorMessage = "Informe o Setor")]
        public string? Setor { get; set; }

        [Display(Name = "Modalidade ou Cidade")]
        [Required(ErrorMessage = "Informe a Cidade ou Modalidade")]
        public string? CidadeModalidade { get; set; }

        [Required(ErrorMessage = "Informe o Status")]
        public int Status { get; set; }
    }
}
