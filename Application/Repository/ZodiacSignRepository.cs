using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Repository
{
    public class ZodiacSignRepository
    {
        public static ZodiacSignRepository Instance { get; } = new();
        public ZodiacSignModel ZodiacSignModel = new();

        private ZodiacSignRepository()
        {

        }
    }
}
