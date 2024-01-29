using CadastroUsuario.Models;
using CadastroUsuario.Models.TableViewModels;
using CadastroUsuario.Models.ViewModels;
using CadastroUsuario.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroUsuario.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            UsuarioService usuarioService = new UsuarioService();

            var userList = usuarioService.GetUsers();

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
        public ActionResult Add(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

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