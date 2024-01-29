using CadastroUsuario.Interfaces;
using CadastroUsuario.Models;
using CadastroUsuario.Models.TableViewModels;
using CadastroUsuario.Models.ViewModels;
using CadastroUsuario.Service;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CadastroUsuario.Controllers
{
    public class UserController : Controller
    {
        private IUsuarioService _usuarioService;
        public UserController()
        {
            _usuarioService = new UsuarioService();
        }

        // GET: User
        public ActionResult Index()
        {
            var userList = _usuarioService.GetUsers();

            List<UserTableViewModel> lst = null;

            lst = (from d in userList
                   select new UserTableViewModel
                   {
                       UsuarioId = d.UsuarioId,
                       Nome = d.Nome,
                       Login = d.Login,
                       Senha = d.Senha,
                       IsAdmin = d.IsAdmin
                   }).ToList();

            return View(lst);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Add(UserViewModel userViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userViewModel);
            }

            UsuarioModel usuarioModel = new UsuarioModel();

            usuarioModel.Nome = userViewModel.Nome;
            usuarioModel.Login = userViewModel.Login;
            usuarioModel.Senha = userViewModel.Senha;
            usuarioModel.IsAdmin = userViewModel.IsAdmin;

            _usuarioService.InsertUser(usuarioModel);

            return Redirect(Url.Content("~/User/Index"));
        }

        public ActionResult Edit(int Id)
        {
            EditUserViewModel model = new EditUserViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(EditUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return Redirect(Url.Content("~/User/Index"));

        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            return Content("1");

        }

    }
}