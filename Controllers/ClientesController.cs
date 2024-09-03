using Microsoft.AspNetCore.Mvc;

namespace Recyclica_Prototipo.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Relatorio()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Confirmacao_Apagar()
        {
            return View();
        }
    }
}
