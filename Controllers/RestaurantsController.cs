using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using RestaurantReviewer.Interfaces;
using RestaurantReviewer.Models;
using RestaurantReviewer.ViewModels;

namespace RestaurantReviewer.Controllers
{
    public class RestaurantsController : Controller
    {
            private readonly IRestaurantRepository _restaurantRepository;
            private readonly ICategoryRepository _categoryRepository;
            private readonly IReviewRepository _reviewRepository;
            private readonly Context _context;

      public RestaurantsController(IRestaurantRepository restaurantRepository, ICategoryRepository categoryRepository ,IReviewRepository reviewRepository,Context context)
            {
                _restaurantRepository = restaurantRepository;
                _categoryRepository = categoryRepository;
                _reviewRepository = reviewRepository;
                _context = context;
            }
        public async Task<IActionResult> Restaurant(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = _restaurantRepository.Restaurant.FirstOrDefault(m => m.RestaurantId == id);
           
            if (restaurant == null)
            {
                return NotFound();
            }
            var restaurantVM = new RestaurantViewModel
            {
                CarouselImage1 = restaurant.CarouselImage1,
                CarouselImage2 = restaurant.CarouselImage2,
                CarouselImage3 = restaurant.CarouselImage3,
                RestaurantId = restaurant.RestaurantId,
                RestaurantName = restaurant.RestaurantName,
                Phone = restaurant.Phone,
                Hours = restaurant.Hours,
                Keywords = restaurant.Keywords,
                Website = restaurant.Website,
                
            
            };

            return View(restaurantVM);
        }
       
        public IActionResult List(int id)
        {
            IEnumerable<Category> categories;
            IEnumerable<Restaurant> restaurants;
            string currentCategory = string.Empty;
            int _category = id;
            categories = _categoryRepository.Category.OrderBy(n => n.CategoryId);
            if (id == 0)
            {
                restaurants = _restaurantRepository.Restaurant.OrderBy(n => n.RestaurantId);
                currentCategory = "All restaurants";
            }
            else
            {
                if (_category == 1)
                {
                    restaurants = _restaurantRepository.Restaurant.Where(p => p.Category.NameCategory.Equals("bistro"));
                    currentCategory = "Bistro";
                }
                else if (_category == 2)
                {
                    restaurants = _restaurantRepository.Restaurant.Where(p => p.Category.NameCategory.Equals("pizza"));
                    currentCategory = "Pizza places";
                }
                else if (_category == 3)
                {
                    restaurants = _restaurantRepository.Restaurant.Where(p => p.Category.NameCategory.Equals("traditional"));
                    currentCategory = "Traditional restaurants";
                }

                else if (_category == 4)
                {
                    restaurants = _restaurantRepository.Restaurant.Where(p => p.Category.NameCategory.Equals("fancy"));
                    currentCategory = "Fancy restaurants";
                }

                else 
                {
                    restaurants = _restaurantRepository.Restaurant.Where(p => p.Category.NameCategory.Equals("sweets"));
                    currentCategory = "Cookies and Sweets";
                }

            }

            var listRestaurants = new RestaurantList
            {
                Restaurants = restaurants,
                CurrentCategory = currentCategory,
                Categories = categories
            };

            return View(listRestaurants);
        }
        [HttpPost]
        public ActionResult SendReview(RestaurantViewModel restaurantViewModel)
        {
            var username = HttpContext.Session.GetString("username");
            restaurantViewModel.Date = DateTime.Now;
            restaurantViewModel.Username = _context.Users.Single(a=>a.Username==username).Username;
            restaurantViewModel.RestaurantId =1;

            Review review = new Review();
            review.Date = restaurantViewModel.Date;
            review.Username = restaurantViewModel.Username;
            review.ReviewDescription = restaurantViewModel.ReviewDescription;
            review.User = restaurantViewModel.User;
            review.RestaurantId = restaurantViewModel.RestaurantId;
            _context.Reviews.Add(review);
            _context.SaveChanges();

            return RedirectToAction("Restaurant", "Restaurants", new { id=restaurantViewModel.RestaurantId });
        }
        public IActionResult ReviewList(int? id)
        {
            List<Review> ReviewList = new List<Review>();
            if (id == null)
            {
                return NotFound();
            }
            Restaurant restaurant = _context.Restaurants.FirstOrDefault(m => m.RestaurantId == id);
            if(_context.Reviews.Where(m => m.RestaurantId == restaurant.RestaurantId).ToList() == null)
            {
                return NotFound();
            }
            ReviewList = _context.Reviews.Where(m => m.RestaurantId == restaurant.RestaurantId).ToList();
            return View(ReviewList);
            
        }

        // GET: Restaurants/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_categoryRepository.Category, "CategoryId", "CategoryId");
            return View();
        }

        // POST: Restaurants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RestaurantId,RestaurantName,Street,Phone,Website,Hours,CategoryId,ImageUrl,CarouselImage1,CarouselImage2,CarouselImage3")] Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _restaurantRepository.Add(restaurant);
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_categoryRepository.Category, "CategoryId", "CategoryId", restaurant.CategoryId);
            return View(restaurant);
        }

        // GET: Restaurants/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = _restaurantRepository.Restaurant.Where(c => c.RestaurantId == id).FirstOrDefault();
            if (restaurant == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_restaurantRepository.Category, "CategoryId", "CategoryId", restaurant.CategoryId);
            return View(restaurant);
        }

        // POST: Restaurants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RestaurantId,RestaurantName,Street,Phone,Website,Hours,CategoryId,ImageUrl,CarouselImage1,CarouselImage2,CarouselImage3")] Restaurant restaurant)
        {
            if (id != restaurant.RestaurantId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _restaurantRepository.Update(restaurant);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestaurantExists(restaurant.RestaurantId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_categoryRepository.Categories, "CategoryId", "CategoryId", restaurant.CategoryId);
            return View(restaurant);
        }

        private bool RestaurantExists(int id)
        {
            return _restaurantRepository.Restaurant.Any(e => e.RestaurantId == id);
        }

        //GET: Restaurants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants.Include(r => r.Category).FirstOrDefaultAsync(m => m.RestaurantId == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            return View(restaurant);
        }

        // POST: Restaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restaurant = _restaurantRepository.Restaurant.Where(c => c.RestaurantId == id).FirstOrDefault();
            restaurant.Delete(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
