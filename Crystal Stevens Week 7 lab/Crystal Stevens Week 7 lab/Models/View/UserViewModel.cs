using System;
using System.ComponentModel.DataAnnotations;

namespace Crystal_Stevens_Week_7_lab.Models.View
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Middle Name")]
        public string middleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string emailAddress { get; set; }

        [Required]
        [Display(Name = "Years in School")]
        public int yearsInSchool { get; set; }

    }
}