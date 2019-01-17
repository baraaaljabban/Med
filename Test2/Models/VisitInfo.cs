using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Models
{
    public class VisitInfo
    {
        [Key]
        public int VisitInfoId { get; set; }
        public Patiant patiant { get; set; }
        public Payment payment { get; set; }
        public Unit Unit { get; set; }
        public Doctor Doctor { get; set; }
        public bool ResultRecived { get; set; }
        public int DiscountAmount { get; set; }
        public string Title { get; set; }
    }
}
