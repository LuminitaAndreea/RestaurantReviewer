using Microsoft.AspNetCore.Mvc;
using RestaurantReviewer.Models;
using RestaurantReviewer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Components
{
    public class FavoriteCartSummary:ViewComponent
    {
        private readonly FavoriteCart _favoriteCart;
        public FavoriteCartSummary(FavoriteCart favoriteCart)
        {
            _favoriteCart = favoriteCart;
        }
        public IViewComponentResult Invoke()
        {
            var items = _favoriteCart.GetFavoriteRestaurants(); 
            _favoriteCart.FavoriteRestaurants = items;

            var favcartViewModel = new FavoriteCartViewModel
            {
                FavoriteCart = _favoriteCart
            };
            return View(favcartViewModel);
        }

    }
}
