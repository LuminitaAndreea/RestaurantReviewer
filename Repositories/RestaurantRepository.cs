using Microsoft.EntityFrameworkCore;
using RestaurantReviewer.Interfaces;
using RestaurantReviewer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RestaurantReviewer.Repositories
{
    public class RestaurantRepository: IRestaurantRepository
    {
        private readonly Context _context;
        public RestaurantRepository(Context context)
        {
            _context = context;
        }
        public IEnumerable<Restaurant> Restaurant => _context.Restaurants.Include(c => c.Category);

        public IEnumerable Category => throw new NotImplementedException();

        public void Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
        }


        public void Update(Restaurant restaurant)
        {
            _context.Restaurants.Update(restaurant);
            _context.SaveChanges();
        }


        public void Delete(int id)
        {
            _context.Restaurants.Remove(Restaurant.Where(c => c.RestaurantId == id).FirstOrDefault());
            _context.SaveChanges();
        }
    }
}
