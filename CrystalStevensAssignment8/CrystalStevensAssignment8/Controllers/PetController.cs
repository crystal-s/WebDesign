using CrystalStevensAssignment8.Models.View;
using CrystalStevensAssignment8.Services;
using System.Web.Mvc;

namespace CrystalStevensLab3Week4.Controllers
{

    public class PetController : Controller
    {
        private readonly IPetService _repo;

        public PetController(IPetService repo)
        {
            _repo = repo;
        }

        public ActionResult List(int userId)
        {
            ViewBag.UserId = userId;

            var pets = _repo.GetPetsForUser(userId);

            return View(pets);
        }

        public ActionResult Details(int id)
        {

            var pet = _repo.GetPet(id);

            return View(pet);
        }

        [HttpGet]
        public ActionResult Create(int userId)
        {
            ViewBag.UserId = userId;

            return View();
        }

        [HttpPost]
        public ActionResult Create(PetViewModel petViewModel)
        {
            if (ModelState.IsValid)
            {
                _repo.SavePet(petViewModel);
            }
            return RedirectToAction("List", new { userId=petViewModel.UserId });
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

                return RedirectToAction("List", new { userId= petViewModel.UserId });
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            var pet = _repo.GetPet(id);
            _repo.DeletePet(id);

            return RedirectToAction("List", new { UserId = pet.UserId });
        }
    }
}