using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Models
{
    public class Review
    {
        [Key] public int ReviewId { get; set; }
        public string ReviewDescription { get; set; }
        public virtual User User { get; set; }
        public string Username { get; set; }
        public int RestaurantId { get; set; }
        public int Rate { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public DateTime Date { get; set; }
    }
}
