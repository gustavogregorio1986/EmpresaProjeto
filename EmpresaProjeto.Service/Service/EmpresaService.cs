﻿using EmpresaProjeto.Data.Repository.Interface;
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

        public void AdicionarMensagem(Mensagem mensagem)
        {
            _empresaRepository.AdicionarMensagem(mensagem);
        }

        public List<Empresa> ListarEmpresas(int paginaAtual, int itensPorPagina, out int totalIntens)
        {
            return _empresaRepository.ListarEmpresas(paginaAtual, itensPorPagina, out totalIntens);
        }

        public List<Mensagem> ListarMensagens()
        {
            return _empresaRepository.ListarMensagens();
        }
    }
}
