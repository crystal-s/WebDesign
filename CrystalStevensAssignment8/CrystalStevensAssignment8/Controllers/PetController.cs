using CrystalStevensAssignment8.Models.View;
using CrystalStevensAssignment8.Services;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;

namespace CrystalStevensAssignment8.Controllers
{
    [Authorize]
    public class PetController : Controller
    {
        private readonly IPetService _repo;

        public PetController(IPetService repo)
        {
            _repo = repo;
        }

        public ActionResult List()
        {
            var userId = User.Identity.GetUserId();

            var pets = _repo.GetPetsForUser(userId);

            return View(pets);
        }

        public ActionResult Details(int id)
        {

            var pet = _repo.GetPet(id);

            return View(pet);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PetViewModel petViewModel)
        {
            if (!ModelState.IsValid)
            { return View(); }

            try
            {
                var userId = User.Identity.GetUserId();
                _repo.SavePet(userId, petViewModel);
            }
            catch
            {
                //logging here
                throw;
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var pet = _repo.GetPet(id);

            return View(pet);
        }

        [HttpPost]
        public ActionResult Edit(PetViewModel petViewModel)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdatePet(petViewModel);

                return RedirectToAction("List");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            _repo.DeletePet(id);

            return RedirectToAction("List");
        }
    }
}