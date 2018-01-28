using CrystalStevensWeek3Lab.Data.Entities;
using System.Collections.Generic;

namespace CrystalStevensWeek3Lab.Data
{
    public class Database
    {
        public static List<User> Users = new List<User>();
        public static int Id = 0;

        public static int NextId()
        {
            return Id++;
        }
        
    }
}
