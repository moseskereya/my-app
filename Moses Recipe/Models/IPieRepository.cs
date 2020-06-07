using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moses_Recipe.Models
{
   public  interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesoftheWeek { get; }
        Pie GetPieById(int pieId);
    }
}
