using CrystalStevensAssignment8.Data.Entities;
using System.Collections.Generic;

namespace CrystalStevensAssignment8.Repositories
{

    public interface IEntityRepository
    {
        Pet GetPet(int id);

        IEnumerable<Pet> GetPetsForUser(string userId);

        void SavePet(Pet pet);

        void UpdatePet(Pet user);

        void DeletePet(int id);
    }
}