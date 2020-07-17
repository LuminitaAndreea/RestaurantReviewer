using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantReviewer.Models
{
    public class User
    {
        [Key] public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int CartId { get; set; }
        public FavoriteCart FavoriteCart { get; set; }
        
    }
}
