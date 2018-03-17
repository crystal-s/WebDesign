using CrystalStevensLab3Week4.Models.View;
using System.Collections.Generic;

namespace CrystalStevensLab3Week4.Services
{
    public interface IPetService
    {
        PetViewModel GetPet(int id);

        IEnumerable<PetViewModel> GetPetsForUser(int userId);

        void SavePet(PetViewModel pet);

        void UpdatePet(PetViewModel user);

        void DeletePet(int id);

        IEnumerable<Data.Entities.Pet> GetAllPets();
    }
}