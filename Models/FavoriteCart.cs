using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models
{
    public class FavoriteCart
    {
        private readonly Context _context;
        private FavoriteCart(Context context)
        {
            _context = context;
        }
        [Key] public string CartId { get; set; }
        public List<FavoriteRestaurant> FavoriteRestaurants { get; set; }

        public static FavoriteCart GetCart(IServiceProvider services)
        {
            
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            var context = services.GetService<Context>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);
            return new FavoriteCart(context) { CartId = cartId };
        }

        public void AddToCart(Restaurant restaurant)
        {
            var favoriteRestaurant = _context.FavoriteRestaurants.SingleOrDefault(
                s => s.Restaurant.RestaurantId == restaurant.RestaurantId && s.CartId== CartId);
            if (favoriteRestaurant == null)
            {
                favoriteRestaurant = new FavoriteRestaurant
                {
                    CartId = CartId,
                    Restaurant = restaurant
                };

                _context.FavoriteRestaurants.Add(favoriteRestaurant);
            }
            _context.SaveChanges();
        }
        public void RemoveFromCart(Restaurant restaurant)
        {
            var favoriteRestaurant = _context.FavoriteRestaurants.SingleOrDefault(
                s => s.Restaurant.RestaurantId == restaurant.RestaurantId && s.CartId == CartId);
            if (favoriteRestaurant != null)
            {
                _context.FavoriteRestaurants.Remove(favoriteRestaurant);
            }
            _context.SaveChanges();
        }
        public List<FavoriteRestaurant> GetFavoriteRestaurants()
        {
            return FavoriteRestaurants ??
                (
                FavoriteRestaurants = _context.FavoriteRestaurants.Where(c => c.CartId== CartId)
                .Include(s => s.Restaurant)
                .ToList());


        }
    }
}
