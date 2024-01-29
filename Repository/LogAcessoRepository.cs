using CadastroUsuario.Data;
using CadastroUsuario.Interfaces;
using CadastroUsuario.Models;
using Dapper;

namespace CadastroUsuario.Repository
{
    public class LogAcessoRepository : ILogAcessRepository
    {
        public bool UserLogAccess(LogAccessModel logAccessModel)
        {
            DynamicParameters parameter = new DynamicParameters();

            parameter.Add("@USUARIOID", logAccessModel.UsuarioId);
            parameter.Add("@DATAHORAACESSO", logAccessModel.DataHoraAcesso);
            parameter.Add("@ENDERECOIP", logAccessModel.EnderecoIp);

            var dapperORM = new DapperORM();

            dapperORM.ExecuteWithoutReturn("SP_LOGACCESS_USER", parameter);

            return true;
        }
    }
}