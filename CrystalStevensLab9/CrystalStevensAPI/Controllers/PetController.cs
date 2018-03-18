using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CrystalStevensLab3Week4.Data.Entities;
using CrystalStevensLab3Week4.Data;
using System.Web.Mvc;

namespace CrystalStevensAPI.Controllers
{
    [System.Web.Http.RoutePrefix("api/pet")]
    public class PetController : ApiController
    {
        //// GET: Pet
        //public ActionResult Index()
        //{
        //    return View();
        //}
        
        private AppDbContext _dbContext;

        public PetController()
        {
            _dbContext = new AppDbContext();
        }

        [System.Web.Http.HttpGet]
        public IEnumerable<Pet> GetAllPets()
        {
            return _dbContext.Pets.ToList();
        }

        [System.Web.Http.Route("{id}")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetPet(int id)
        {
            var pet = _dbContext.Pets.FirstOrDefault((p) => p.Id == id);
            if (pet == null)
            {
                return NotFound();
            }
            return Ok(pet);
        }
    }
}