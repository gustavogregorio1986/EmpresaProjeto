using Microsoft.AspNetCore.Mvc;

namespace EmpresaProjeto.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
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
