using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalStevensWeek3Lab.Data.Entities
{
    public class User
    {
       
        public int Id { get; set; }

        [Required]
        public string firstName { get; set; }

        public string middleName { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        public string emailAddress { get; set; }

        [Required]
        public int yearsInSchool { get; set; }
       
    }
}
