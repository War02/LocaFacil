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
        public IActionResult Editar(int id)
        {
            CarroModel carro = _carroRepositorio.BuscarPorId(id);
            return View(carro);
        }
        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _carroRepositorio.Apagar(id);

                if (apagado) TempData["MensagemSucesso"] = "Veículo apagado com sucesso"; else TempData["MensagemErro"] = "Ops, não conseguimos apagar este veículo";
                return RedirectToAction("Index");

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar este veículo. Detalhe do erro {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(CarroModel carro)
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
        [HttpPost]
        public IActionResult Editar(CarroModel carroModel)
        {
            try
            {
                CarroModel carro = null;

                if (ModelState.IsValid)
                {
                    carroModel = new CarroModel()
                    {
                        Id = carroModel.Id,
                        Marca = carroModel.Marca,
                        Modelo = carroModel.Modelo,
                        Km = carroModel.Km,
                        Cor = carroModel.Cor,
                        Transmissao = carroModel.Transmissao,
                    };

                    carroModel = _carroRepositorio.Atualizar(carroModel);

                    TempData["MensagemDeSucesso"] = "Veículo atualizado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(carroModel);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos atualizar os dados do seu veículo\nDetalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}