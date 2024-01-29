using CadastroUsuario.Interfaces;
using CadastroUsuario.Models;
using CadastroUsuario.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario.Service
{
    public class UsuarioService: IUsuarioService
    {
        private IUserRepository _userRepository;
        public UsuarioService()
        {
            _userRepository = new UserRepository();
        }
        public bool InsertUser(UsuarioModel usuarioModel)
        {
            _userRepository.InsertUser(usuarioModel);

            return true;
        }
        public IEnumerable<UsuarioModel> GetUsers()
        {
            return _userRepository.GetUsers("");
        }
        public UsuarioModel ValidateLogin(UsuarioModel usuarioModel)
        {
            return _userRepository.ValidateUserCredential(usuarioModel);
        }
    }
}
