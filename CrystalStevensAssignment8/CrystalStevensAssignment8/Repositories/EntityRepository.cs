using CrystalStevensAssignment8.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using CrystalStevensAssignment8.Models;

namespace CrystalStevensAssignment8.Repositories
{
    public class EntityRepository : IEntityRepository
    {
        private readonly AppDbContext _dbContext;

        public EntityRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /* Pet Stuff */

        public Pet GetPet(int id)
        {
            return _dbContext.Pets.Find(id);
        }

        public IEnumerable<Pet> GetPetsForUser(string userId)
        {
            return _dbContext.Pets.Where(pet => pet.UserId == userId).ToList();
        }

        public void SavePet(Pet pet)
        {
            _dbContext.Pets.Add(pet);

            _dbContext.SaveChanges();
        }

        public void UpdatePet(Pet pet)
        {
            _dbContext.SaveChanges();
        }

        public void DeletePet(int id)
        {
            var pet = _dbContext.Pets.Find(id);

            if (pet == null) return;

            _dbContext.Pets.Remove(pet);
            _dbContext.SaveChanges();
        }
    }
}