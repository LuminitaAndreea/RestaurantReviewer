using RestaurantReviewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Interfaces
{
    public interface IReviewRepository
    {
        IEnumerable<Review> Review { get; }
    }
}
