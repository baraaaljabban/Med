using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{
    public class Setting
    {
        [Key]
        public int SettingId { get; set; }
        public string LapName { get; set; }
        public string LapAddress { get; set; }
        public string Phone { get; set; }
        public Unit Unit { get; set; }
        public string Notes { get; set; }

    }
}
