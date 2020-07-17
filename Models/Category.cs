using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models
{
    public class Category
    {
        [Key] public int CategoryId { get; set; }
        public string NameCategory { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
    }
}
