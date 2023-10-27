using LocaFacil.Models;
using LocaFacil.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace LocaFacil.Controllers
{
    public class CarroController : Controller
    {
        private readonly ICarroRepositorio _carroRepositorio;

        public CarroController(ICarroRepositorio carroRepositorio)
        {
            _carroRepositorio = carroRepositorio;
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
        public IActionResult Criar(CarroModel carro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    carro = _carroRepositorio.Adicionar(carro);

                    TempData["MensagemDeSucesso"] = "Veículo Cadastrado com sucesso";
                    return RedirectToAction("Index", "Carro");
                }

                return View(carro);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu veículo. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index", "Carro");
            }
        }
    }
}
