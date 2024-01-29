using CadastroUsuario.Models;
using System.Collections.Generic;

namespace CadastroUsuario.Interfaces
{
    public interface IUserRepository
    {

        bool InsertUser(UsuarioModel model);

        bool UpdateUser();

        bool DeleteUser();

        IEnumerable<UsuarioModel> GetUsers(string login = "");

        UsuarioModel ValidateUserCredential(UsuarioModel model);
    }
}