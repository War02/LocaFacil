using Microsoft.AspNetCore.Mvc;

namespace LocaFacil.Controllers
{
    public class CarroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 

        public IActionResult Criar()
        {
            return View();
        }
    }
}
