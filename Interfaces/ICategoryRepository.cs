using RestaurantReviewer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviewer.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Category { get; }
        IEnumerable Categories { get; }
    }
}
