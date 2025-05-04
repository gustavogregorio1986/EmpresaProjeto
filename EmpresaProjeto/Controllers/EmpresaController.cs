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

        public IActionResult Consultar()
        {
            return View();
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
