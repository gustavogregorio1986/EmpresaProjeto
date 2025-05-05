using EmpresaProjeto.Dominio.Dominio;
using EmpresaProjeto.Models;
using EmpresaProjeto.Service.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaProjeto.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IEmpresaService _empresaService;

        public EmpresaController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastar(Empresa empresa)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    EmpresaView empresaView = new EmpresaView();
                    empresaView.NomeEmpresa = empresa.NomeEmpresa;
                    empresaView.Cnpj = empresa.Cnpj;
                    empresaView.Setor = empresaView.Setor;
                    empresaView.CidadeModalidade = empresa.CidadeModalidade;

                    _empresaService.Adicionar(empresa);
                    TempData["MensagemSucesso"] = "Empresa cadastrada com sucesso!";
                    return RedirectToAction("Cadastrar");

                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            return View(empresa);
        }

        [HttpGet]
        public IActionResult Consultar(int paginaAtual = 1, int itensPorPagina = 5)
        {
            var empresas = _empresaService.ListarEmpresas(paginaAtual, itensPorPagina, out int total);

            var viewModel = new IndexView
            { 
                Empresas = empresas,
                TotalItens = total,
                PaginaAtual = paginaAtual,
                ItensPorPagina = itensPorPagina
            };


            return View(viewModel);
        }

        public IActionResult ListarAtivos()
        {
            return View();
        }

        public IActionResult ListarInativos()
        {
            return View();
        }

        public IActionResult ConsultarPorJSON()
        {
            return View();
        }
    }
}
