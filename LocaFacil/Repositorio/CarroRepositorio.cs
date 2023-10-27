using LocaFacil.Data;
using LocaFacil.Models;

namespace LocaFacil.Repositorio
{
    public class CarroRepositorio : ICarroRepositorio
    {
        private readonly BancoContext _context;
        public CarroRepositorio(BancoContext bancoContext)
        {
           this._context = bancoContext;
        }
        public List<CarroModel> BuscarTodos()
        {
            return _context.Carros.ToList();
        }
        public CarroModel Adicionar(CarroModel carro)
        {
            _context.Carros.Add(carro);
            _context.SaveChanges();
            return carro;

        }
    }
}
