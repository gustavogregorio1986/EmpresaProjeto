using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaProjeto.Dominio.Dominio
{
    public class Empresa
    {
        public Guid Id { get; set; }

        public string? NomeEmpresa { get; set; }

        public string? Cnpj { get; set; }


        public string? Setor { get; set; }

        public string? CidadeModalidade { get; set; }

        public int Status { get; set; }
    }
}
