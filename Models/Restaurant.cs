using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RestaurantReviewer.Models
{
    public class Restaurant
    {
        [Key] public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string Street { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Hours { get; set; }
        public string Keywords { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string ImageUrl { get; set; }
        public string CarouselImage1 { get; set; }
        public string CarouselImage2 { get; set; }
        public string CarouselImage3 { get; set; }
        public int RateCount
        {
            get { return Reviews.Count; }
        }
        public int RateAverage
        {
            get { return (Reviews.Sum(m => m.Rate)); }
        }

        internal void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
