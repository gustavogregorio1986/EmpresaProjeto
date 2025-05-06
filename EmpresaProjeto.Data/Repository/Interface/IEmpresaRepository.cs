using EmpresaProjeto.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaProjeto.Data.Repository.Interface
{
    public interface IEmpresaRepository
    {
        void Adicionar(Empresa empresa);

        void AdicionarMensagem(Mensagem mensagem);

        List<Empresa> ListarEmpresas(int paginaAtual, int itensPorPagina, out int totalIntens);

        List<Mensagem> ListarMensagens();
    }
}
