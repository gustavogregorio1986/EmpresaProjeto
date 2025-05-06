using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaProjeto.Dominio.Dominio
{
    public class Mensagem
    {
        public Guid Id { get; set; }

        public string? NomePessoa { get; set; }

        public string? Assunto { get; set; }

        public string? Descricao { get; set; }
    }
}
