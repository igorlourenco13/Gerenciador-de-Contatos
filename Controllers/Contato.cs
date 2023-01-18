using Microsoft.AspNetCore.Mvc;

namespace CONTATOS.Controllers
{
    public class Contato : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarComfirmacao()
        {
            return View();
        }
    }
}
