using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RestaurantReviewer.Interfaces;
using RestaurantReviewer.Models;
using RestaurantReviewer.ViewModels;

namespace RestaurantReviewer.Controllers
{
    public class FavoriteCartController : Controller
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly FavoriteCart _favoriteCart;
        public FavoriteCartController(IRestaurantRepository restaurantRepository, FavoriteCart favoriteCart) 
        {
            _restaurantRepository = restaurantRepository;
            _favoriteCart = favoriteCart;
        }
        public ViewResult Index()
        {
            var items = _favoriteCart.GetFavoriteRestaurants();
            _favoriteCart.FavoriteRestaurants = items;

            var fcvm = new FavoriteCartViewModel
            {
                FavoriteCart = _favoriteCart

            };
            return View(fcvm);
        }
       
        public RedirectToActionResult AddToFavoriteCart(int restaurantId)
        {
            var selectedRestaurant = _restaurantRepository.Restaurant.FirstOrDefault(p => p.RestaurantId==restaurantId);
            if (selectedRestaurant != null)
            {
                _favoriteCart.AddToCart(selectedRestaurant);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromFavoriteCart(int restaurantId)
        {
            var selectedRestaurant = _restaurantRepository.Restaurant.FirstOrDefault(p => p.RestaurantId == restaurantId);
            if (selectedRestaurant != null)
            {
                _favoriteCart.RemoveFromCart(selectedRestaurant);
            }
            return RedirectToAction("Index");
        }
    }
}