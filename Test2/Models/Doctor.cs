﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Models
{
   public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        public string Name { get; set; }
    }
}
