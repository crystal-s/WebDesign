﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrystalStevensLab3Week4.Data.Entities
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public bool Chipped { get; set; }

        public DateTime NextCheckup { get; set; }

        public string VetName { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}