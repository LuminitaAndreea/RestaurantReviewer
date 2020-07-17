using RestaurantReviewer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantReviewer.ViewModels
{
    public class RestaurantViewModel
    {
        public string RestaurantName { get; set; }
        public int RestaurantId { get; set; }
        public string Street { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Hours { get; set; }
        public string Keywords { get; set; }
        public string CarouselImage1 { get; set; }
        public string CarouselImage2 { get; set; }
        public string CarouselImage3 { get; set; }
        public DateTime Date { get; set; }
        public string ReviewDescription { get; set; }
        public virtual User User { get; set; }
        public string Username { get; set; }
        public int Rate { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public int RateCount
        {
            get { return Reviews.Count; }
        }
    }
}
