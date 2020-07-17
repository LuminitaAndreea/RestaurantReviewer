using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models
{
    public class FavoriteRestaurant
    {

        [Key] public int FavoriteId{ get; set; }

        public Restaurant Restaurant { get; set; }

        public string CartId { get; set; }
    }
}
