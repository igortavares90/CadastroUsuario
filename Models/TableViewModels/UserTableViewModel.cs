using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroUsuario.Models.TableViewModels
{
    public class UserTableViewModel
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool IsAdmin { get; set; }

    }
}