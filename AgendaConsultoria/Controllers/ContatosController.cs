using Microsoft.AspNetCore.Mvc;

namespace AgendaConsultoria.Controllers
{
    public class ContatosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
