using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class ZodiacSignModel
    {
        public int day { get; set; }
        public int month { get; set; }
        public string results { get; set; } = String.Empty;
    }
}
