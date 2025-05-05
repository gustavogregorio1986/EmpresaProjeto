using EmpresaProjeto.Data.Context;
using EmpresaProjeto.Data.Repository.Interface;
using EmpresaProjeto.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaProjeto.Data.Repository
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly DbContexto _dbContexto;

        public EmpresaRepository(DbContexto dbContexto)
        {
            _dbContexto = dbContexto;
        }

        public void Adicionar(Empresa empresa)
        {
            _dbContexto.Add(empresa);
            _dbContexto.SaveChanges();
        }

        public List<Empresa> ListarEmpresas(int paginaAtual, int itensPorPagina, out int totalIntens)
        {
            totalIntens = _dbContexto.Empresas.Count();

            return _dbContexto.Empresas
                .OrderBy(e => e.NomeEmpresa).Skip((paginaAtual - 1) * itensPorPagina)
                .Take(totalIntens)
                .ToList();
        }
    }
}
