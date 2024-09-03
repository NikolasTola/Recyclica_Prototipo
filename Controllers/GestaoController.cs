using Microsoft.AspNetCore.Mvc;

namespace Recyclica_Prototipo.Controllers
{
    public class GestaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Aprovacoes()
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
