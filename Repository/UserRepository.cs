using CadastroUsuario.Data;
using CadastroUsuario.Interfaces;
using CadastroUsuario.Models;
using Dapper;
using System;
using System.Collections.Generic;

namespace CadastroUsuario.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool DeleteUser()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioModel> GetUsers(string login = "")
        {
            DynamicParameters parameter = new DynamicParameters();

            var dapperORM = new DapperORM();

            return dapperORM.ReturnList<UsuarioModel>("SP_SELECT_USER", parameter);
        }

        public bool InsertUser(UsuarioModel model)
        {
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Nome", model.Nome);
            parameter.Add("@Login", model.Login);
            parameter.Add("@Senha", model.Senha);
            parameter.Add("@isAdmin", model.IsAdmin);

            var dapperORM = new DapperORM();

            dapperORM.ExecuteWithoutReturn("SP_INSERT_USER", parameter);

            return true;
        }

        public bool UpdateUser()
        {
            throw new NotImplementedException();
        }

        public UsuarioModel ValidateUserCredential(UsuarioModel model)
        {
            var dapperORM = new DapperORM();

            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@Login", model.Login);
            parameter.Add("@Senha", model.Senha);

            var command = "SELECT * FROM Usuario WHERE Login='" + model.Login + "' AND Senha='" + model.Senha + "'";

            var result = dapperORM.ReturnObject<UsuarioModel>(command);

            if (result != null)
                return result;
            else
                return null;
        }
    }
}