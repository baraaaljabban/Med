using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }
        public int UnitPrice { get; set; }
        public string UnitName { get; set; }

    }
}
