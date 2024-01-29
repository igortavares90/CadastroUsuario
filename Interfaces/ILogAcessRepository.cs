using CadastroUsuario.Models;

namespace CadastroUsuario.Interfaces
{
    public interface ILogAcessRepository
    {
        bool UserLogAccess(LogAccessModel logAccessModel);
    }
}