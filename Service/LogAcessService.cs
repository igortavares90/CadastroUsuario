using CadastroUsuario.Interfaces;
using CadastroUsuario.Models;
using CadastroUsuario.Repository;

namespace CadastroUsuario.Service
{
    public class LogAccessService
    {
        private ILogAcessRepository _logAccessRepository;
        public LogAccessService()
        {
            _logAccessRepository = new LogAcessoRepository();
        }
        public bool UserLogAccess(LogAccessModel logAccessModel)
        {
            _logAccessRepository.UserLogAccess(logAccessModel);

            return true;
        }
    }
}