using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario.Interfaces
{
    public interface IDapperORM
    {
        void ExecuteWithoutReturn(string procedureName, DynamicParameters param);
        T ExecuteWithReturn<T>(string procedureName, DynamicParameters param);
    }
}
