using CrystalStevensAssignment8.Models.View;
using System.Collections.Generic;

namespace CrystalStevensAssignment8.Services
{
    public interface IPetService
    {
        PetViewModel GetPet(int id);

        IEnumerable<PetViewModel> GetPetsForUser(int userId);

        void SavePet(PetViewModel pet);

        void UpdatePet(PetViewModel user);

        void DeletePet(int id);
    }
}