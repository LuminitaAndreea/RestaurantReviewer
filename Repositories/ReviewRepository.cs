using Microsoft.EntityFrameworkCore;
using RestaurantReviewer.Interfaces;
using RestaurantReviewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly Context _context;
        public ReviewRepository(Context context)
        {
            _context = context;
        }
        public IEnumerable<Review> Review => _context.Reviews.Include(c => c.Restaurant);

    }
}
