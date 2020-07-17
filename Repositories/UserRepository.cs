using Microsoft.EntityFrameworkCore;
using RestaurantReviewer.Interfaces;
using RestaurantReviewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly Context _context;
        public UserRepository(Context context)
        {
            _context = context;
        }
     
        public IEnumerable<User> User => _context.Users.Include(c => c.FavoriteCart);

    }
}
