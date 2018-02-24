using System.Collections.Generic;
using System.Web.Mvc;
using CrystalStevensLab3Week4.Data;
using CrystalStevensLab3Week4.Data.Entities;
using CrystalStevensLab3Week4.Models.View;
using CrystalStevensLab3Week4.Repositories;
using CrystalStevensLab3Week4.Services;

namespace CrystalStevensLab3Week4.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _repo;

        public UserController(IUserService userService)
        {
            _repo = userService;
        }

        public ActionResult List()
        {
            var users = _repo.GetAllUsers();

            return View(users);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                _repo.SaveUser(userViewModel);

                return RedirectToAction("List");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            var user = _repo.GetUser(id);

            return View(user);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var user = _repo.GetUser(id);

            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateUser(userViewModel);

                return RedirectToAction("List");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            _repo.DeleteUser(id);

            return RedirectToAction("List");
        }
    }
}