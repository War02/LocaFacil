using LocaFacil.Filters;
using LocaFacil.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LocaFacil.Controllers
{
    [PaginaParaUsuarioLogado]
    public class HomeLogadoController : Controller
    {
        private readonly ILogger<HomeLogadoController> _logger;

        public HomeLogadoController(ILogger<HomeLogadoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
            {
                return View();
            }
        
        public IActionResult MeuPerfil()
        {
            return View();
        }

            public IActionResult Privacy()
            {
                return View();
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        [PaginaParaUsuarioLogado]

        public IActionResult VerDetalhes()
        {
            return View();
        }
        [PaginaParaUsuarioLogado]

        public IActionResult VerDetalhesMobi()
        {
            return View();
        }
        [PaginaParaUsuarioLogado]

        public IActionResult VerDetalhesHb()
        {
            return View();
        }
        [PaginaParaUsuarioLogado]

        public IActionResult VerDetalhesRene()
        {
            return View();
        }
        [PaginaParaUsuarioLogado]

        public IActionResult VerDetalhesPejo()
        {
            return View();
        }
        [PaginaParaUsuarioLogado]

        public IActionResult VerDetalhesGol()
        {
            return View();
        }
    }
    }