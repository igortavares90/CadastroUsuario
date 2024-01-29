using System.ComponentModel.DataAnnotations;

namespace CadastroUsuario.Models.ViewModels
{
    public class UserViewModel
    {
        [Required]
        public int UsuarioId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
    }

    public class EditUserViewModel
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
    }
}