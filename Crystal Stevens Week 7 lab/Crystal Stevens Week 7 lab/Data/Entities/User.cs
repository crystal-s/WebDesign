using System.ComponentModel.DataAnnotations;

namespace Crystal_Stevens_Week_7_lab.Data.Entities
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