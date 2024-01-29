using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroUsuario.Models
{
    public class LogAccessModel
    {
        public int LogAcessoId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataHoraAcesso { get; set; }
        public string EnderecoIp { get; set; }
    }
}