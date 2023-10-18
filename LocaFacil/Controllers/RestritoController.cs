using Microsoft.AspNetCore.Mvc;
using LocaFacil.Filters;

namespace LocaFacil.Controllers
{
    [PaginaParaUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
