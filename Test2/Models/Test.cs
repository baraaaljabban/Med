using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{
    public class Test
    {
        [Key]
        public int TestId { get; set; }
        public int TestCode { get; set; }
        public string TestShortCut { get; set; }
        public Unit Unit { get; set; }
        public int UnitNumber { get; set; }
        public string Notes { get; set; }

    }
}
