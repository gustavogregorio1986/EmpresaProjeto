using EmpresaProjeto.Data.Repository.Interface;
using EmpresaProjeto.Dominio.Dominio;
using EmpresaProjeto.Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaProjeto.Service.Service
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public void Adicionar(Empresa empresa)
        {
            _empresaRepository.Adicionar(empresa);
        }
    }
}
