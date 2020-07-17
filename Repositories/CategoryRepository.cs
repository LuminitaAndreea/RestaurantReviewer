using RestaurantReviewer.Interfaces;
using RestaurantReviewer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context)
        {
            _context = context;
        }
        public IEnumerable<Category> Category => _context.Categories;

        public IEnumerable Categories => throw new NotImplementedException();
    }
}
