using LocaFacil.Models;
using LocaFacil.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace LocaFacil.Controllers
{
    public class CarroController : Controller
    {
        private readonly ICarroRepositorio _carroRepositorio;
        public CarroController(ICarroRepositorio carroRepositorio) {

            this._carroRepositorio = carroRepositorio;
        }
        public IActionResult Index()
        {
            List<CarroModel> carros = _carroRepositorio.BuscarTodos();
            return View(carros);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(CarroModel  carro) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    carro = _carroRepositorio.Adicionar(carro);
                    TempData["MensagemSucesso"] = "Cadastro bem sucedido";
                    return RedirectToAction("Index", "Carro");
                }
                return View(carro);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = "Cadastro nao sucedido";
                return RedirectToAction("Index", "Carro");
            }
        }
    }
}
