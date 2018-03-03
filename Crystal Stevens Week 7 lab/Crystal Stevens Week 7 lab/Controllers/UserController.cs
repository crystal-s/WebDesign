using Crystal_Stevens_Week_7_lab.Data.Entities;
using System.Web.Mvc;

namespace Crystal_Stevens_Week_7_lab.Controllers
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