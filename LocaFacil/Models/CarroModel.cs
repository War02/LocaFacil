using System.ComponentModel.DataAnnotations;

namespace LocaFacil.Models
{
    public class CarroModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite a marca da veículo")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Digite o modelo do veículo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Digite a quilometragem do veículo")]
        public string Km{ get; set; }
        [Required(ErrorMessage = "Digite a cor do veículo ")]
        public string Cor { get; set; }
        [Required(ErrorMessage = "Digite o ano do veículo")]
        public int Ano { get; set; }
        [Required(ErrorMessage = "Digite a transmissão do veículo")]
        public string Transmissao { get; set; }
        [Required(ErrorMessage = "Digite a descrição")]
        public string Descricao { get; set; }
    }
}
