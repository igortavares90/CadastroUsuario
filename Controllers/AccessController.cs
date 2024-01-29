using CadastroUsuario.Models;
using CadastroUsuario.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace CadastroUsuario.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string user, string password)
        {
            try
            {
                UsuarioService usuarioService = new UsuarioService();
                LogAccessService logAcessService = new LogAccessService();

                UsuarioModel usuarioModel = new UsuarioModel();
                LogAccessModel logAccessModel = new LogAccessModel();

                usuarioModel.Login = user;
                usuarioModel.Senha = password;

                string clientIp = (Request.ServerVariables["HTTP_X_FORWARDED_FOR"] ??
                   Request.ServerVariables["REMOTE_ADDR"]).Split(',')[0].Trim();

                var usuario = usuarioService.ValidateLogin(usuarioModel);

                if (usuario != null)
                {
                    Session["User"] = usuario;

                    logAccessModel.UsuarioId = usuario.UsuarioId;
                    logAccessModel.DataHoraAcesso = DateTime.Now;
                    logAccessModel.EnderecoIp = clientIp;

                    logAcessService.UserLogAccess(logAccessModel);


                    return Content("1");
                }
                else
                {
                    return Content("usuario invalido");
                }
            }
            catch (Exception ex)
            {
                return Content("Ocorreu um erro:(" + ex.Message);
            }
        }
    }
}