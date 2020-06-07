using Moses_Recipe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moses_Recipe.Models
{
    public class CategoryRepository : ICategotyRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }



        public IEnumerable<Category> AllCategories => _applicationDbContext.Categories;
    }
}
