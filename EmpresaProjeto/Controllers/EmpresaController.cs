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
                    TempData["MensagemSucesso"] = "Mensagem cadastrada com sucesso!";
                    return RedirectToAction("Cadastrar");

                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            return View(empresa);
        }

        [HttpPost]
        public IActionResult CadastarMensagem(Mensagem mensagem)
        {
            try
            {
                // Verifica se o modelo está válido
                if (ModelState.IsValid)
                {
                    // Chama o serviço para adicionar a mensagem
                    _empresaService.AdicionarMensagem(mensagem);

                    // Armazena uma mensagem de sucesso
                    TempData["MensagemSucesso"] = "Mensagem cadastrada com sucesso!";

                    // Redireciona para a página Consultar
                    return RedirectToAction("Consultar");
                }

                // Caso o ModelState não seja válido, retorna para a mesma view com os dados
                return View(mensagem);
            }
            catch (Exception ex)
            {
                // Trata exceções e exibe no console
                Console.WriteLine("Erro: " + ex.Message);

                // Se ocorrer erro, envia mensagem de erro
                TempData["MensagemErro"] = "Ocorreu um erro ao cadastrar a mensagem.";

                // Redireciona para a página de consulta em caso de erro
                return RedirectToAction("Consultar");
            }
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

        [HttpGet]
        public IActionResult IndListarMensagensex()
        {
            // Suponha que você está buscando as mensagens de um repositório
            var mensagens = _empresaService.ListarMensagens();

            // Passando os dados para a view
            var model = new IndexView
            {
                Mensagens = mensagens
            };

            return View(model);
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
