using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NovoContato()
        {
            return View();
        }

        public IActionResult EditarContato()
        {
            return View();
        }

        public IActionResult ApagarContato()
        {
            return View();
        }
    }
}
