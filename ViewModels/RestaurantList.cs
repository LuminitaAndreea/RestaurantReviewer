using RestaurantReviewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.ViewModels
{
    public class RestaurantList
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string CurrentCategory { get; set; }
    }
}
