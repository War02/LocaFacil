using LocaFacil.Models;

namespace LocaFacil.Repositorio
{
    public interface ICarroRepositorio
    {
        List<CarroModel> BuscarTodos();
        CarroModel BuscarPorId(int id);
        CarroModel Adicionar(CarroModel carro);
        CarroModel Atualizar(CarroModel carro);
        bool Apagar(int id);

    }
}
