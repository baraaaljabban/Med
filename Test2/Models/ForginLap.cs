using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{
    public class ForginLap
    {
        [Key]
        public int ForginLapId { get; set; }
        public string LapName { get; set; }
    }
}
