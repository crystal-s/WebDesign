using System.Collections.Generic;
using Crystal_Stevens_Week_7_lab.Data.Entities;

namespace Crystal_Stevens_Week_7_lab.Data
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