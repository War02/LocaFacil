using System.ComponentModel.DataAnnotations;

namespace LocaFacil.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha do usuário")]
        public String Senha { get; set; }
    }
}
