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
        public CarroModel BuscarPorId(int id)
        {
            return _context.Carros.FirstOrDefault(x => x.Id == id);
        }

        public CarroModel Adicionar(CarroModel carro)
        {
            _context.Carros.Add(carro);
            _context.SaveChanges();
            return carro;

        }
        public CarroModel Atualizar(CarroModel carro)
        {
           CarroModel carroDB = BuscarPorId(carro.Id);

            if (carroDB == null) throw new Exception("Houve um erro na atualização do veículo");

            carroDB.Marca = carro.Marca;
            carroDB.Modelo = carro.Modelo;
            carroDB.Km = carro.Km;
            carroDB.Cor = carro.Cor;
            carroDB.Ano = carro.Ano;
            carroDB.Transmissao = carro.Transmissao;

            

            _context.Carros.Update(carroDB);
            _context.SaveChanges();

            return carroDB;
        }

        
    }
}