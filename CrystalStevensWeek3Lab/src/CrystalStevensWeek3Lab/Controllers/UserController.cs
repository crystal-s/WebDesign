using CrystalStevensWeek3Lab.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CrystalStevensWeek3Lab.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(User user)
        {
           // user.Id = Data.Database.NextId();
            Data.Database.Users.Add(user);

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var users = Data.Database.Users;

            return View(users);
        }
    }
}
