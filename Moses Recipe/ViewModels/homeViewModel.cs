using Moses_Recipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moses_Recipe.ViewModels
{
    public class homeViewModel
    {
        public IEnumerable<Pie> PiesofTheWeek { get; set; }
    }
}
