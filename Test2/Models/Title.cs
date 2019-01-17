using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{
    public class Title
    {


        [Key]
        public int TitleId { get; set; }
        public string TitleName { get; set; }
    }
}
