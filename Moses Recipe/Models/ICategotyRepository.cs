using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moses_Recipe.Models
{
    public interface ICategotyRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
