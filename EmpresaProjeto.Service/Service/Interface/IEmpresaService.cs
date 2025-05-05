using EmpresaProjeto.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaProjeto.Service.Service.Interface
{
    public interface IEmpresaService
    {
        void Adicionar(Empresa empresa);

        List<Empresa> ListarEmpresas(int paginaAtual, int itensPorPagina, out int totalIntens);
    }
}
