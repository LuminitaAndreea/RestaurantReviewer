using RestaurantReviewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace RestaurantReviewer.Interfaces
{
    public interface IRestaurantRepository
    {
        IEnumerable<Restaurant> Restaurant { get; }
        IEnumerable Category { get; }

        void Add(Restaurant restaurant);
        void Update(Restaurant restaurant);
        public void Delete(int id);
    }
}
