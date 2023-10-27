using LocaFacil.Models;

namespace LocaFacil.Repositorio
{
    public interface ICarroRepositorio
    {
        List<CarroModel> BuscarTodos();
        CarroModel Adicionar(CarroModel carro);
    }
}
