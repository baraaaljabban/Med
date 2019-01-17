using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{
    public class Payment
    {
        [Key]

        public int PaymentId { get; set; }
        public String PayMethod { get; set; }
    }
}
