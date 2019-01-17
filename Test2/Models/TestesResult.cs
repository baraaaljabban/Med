using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{
    public class TestesResult
    {
        [Key]
        public int TestResultId { get; set; }
        public string Name { get; set; }
        public Patiant patiant { get; set; }
        public Test Test { get; set; }
        public string Result { get; set; }
        public bool InForginLap { get; set; }
        public ForginLap ForginLap { get; set; }
        public string Notes { get; set; }
    }
}
