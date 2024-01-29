using CadastroUsuario.Models;
using System.Collections.Generic;

namespace CadastroUsuario.Interfaces
{
    public interface IUsuarioService
    {
        bool InsertUser(UsuarioModel usuarioModel);
        IEnumerable<UsuarioModel> GetUsers();
        UsuarioModel ValidateLogin(UsuarioModel usuarioModel);
    }
}