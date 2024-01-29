﻿using CadastroUsuario.Models;
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
            //if (!ModelState.IsValid)
            //{
            //    return View(model);
            //}

            //using (cursomvcEntities db = new cursomvcEntities())
            //{
            //    user oUser = new user();
            //    oUser.idState = 1;
            //    oUser.email = model.Email;
            //    oUser.edad = model.Edad;
            //    oUser.password = model.Password;

            //    db.users.Add(oUser);
            //    db.SaveChanges();


            //}

            return Redirect(Url.Content("~/User/Index"));

        }

        public ActionResult Edit(int Id)
        {
            EditUserViewModel model = new EditUserViewModel();

            //using (var db = new cursomvcEntities())
            //{
            //    var oUser = db.users.Find(Id);
            //    model.Edad = (int)oUser.edad;
            //    model.Email = oUser.email;
            //    model.Id = oUser.Id;

            //}
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(EditUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //using (var db = new cursomvcEntities())
            //{
            //    var oUser = db.users.Find(model.Id);
            //    oUser.email = model.Email;
            //    oUser.edad = model.Edad;

            //    if (model.Password != null && model.Password.Trim() != "")
            //    {
            //        oUser.password = model.Password;
            //    }

            //    db.Entry(oUser).State = System.Data.Entity.EntityState.Modified;
            //    db.SaveChanges();


            //}

            return Redirect(Url.Content("~/User/Index"));

        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            //using (var db = new cursomvcEntities())
            //{
            //    var oUser = db.users.Find(Id);
            //    oUser.idState = 3;

            //    db.Entry(oUser).State = System.Data.Entity.EntityState.Modified;
            //    db.SaveChanges();


            //}

            return Content("1");

        }

    }
}