using CrystalStevensLab3Week4.Data.Entities;
using System.Collections.Generic;

namespace CrystalStevensLab3Week4.Repositories
{

    public interface IEntityRepository
    {
        User GetUser(int id);

        IEnumerable<User> GetAllUsers();

        void SaveUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int id);

        Pet GetPet(int id);

        IEnumerable<Pet> GetPetsForUser(int userId);

        void SavePet(Pet pet);

        void UpdatePet(Pet user);

        void DeletePet(int id);
    }
}