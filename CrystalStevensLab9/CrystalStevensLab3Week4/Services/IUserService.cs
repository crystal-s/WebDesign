using CrystalStevensLab3Week4.Models.View;
using System.Collections.Generic;

namespace CrystalStevensLab3Week4.Services
{
    public interface IUserService
    {
        UserViewModel GetUser(int id);

        IEnumerable<UserViewModel> GetAllUsers();

        void SaveUser(UserViewModel user);

        void UpdateUser(UserViewModel user);

        void DeleteUser(int id);
    }
}