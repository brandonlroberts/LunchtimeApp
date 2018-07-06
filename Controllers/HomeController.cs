using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LunchApp.Models;
using LunchApp.Models.ViewModels;
using LunchApp.Dal;
using LunchApp.Dal.Interfaces;
using LunchApp.Dal.Repos;

namespace LunchApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantRepo _restaurantRepo;

        public HomeController(IRestaurantRepo restaurantRepo)
        {
            _restaurantRepo = restaurantRepo;
        }

        public IActionResult Index()
        {
            var restaurant = GetRestaurantsViewModel(); 

            return View(restaurant);
        }

        public RestaurantsViewModel GetRestaurantsViewModel()
        {
            var rvm = new RestaurantsViewModel
            {
                Restaurants = _restaurantRepo.GetListOfRestaurants()
            };            

            return rvm;
        }

        [HttpPost]
        public IActionResult PickRandom(List<Restaurant> restaurants)
        {

            Random random = new Random();
            var names = new List<string>();

            foreach (var item in restaurants)
            {
                if (item.IsSelected)
                {
                    names.Add(item.Name);
                }
            }

            if (names.Count < 1)
            {
                ModelState.AddModelError("IsSelected", "You must select at least one restaurant...");
                var reload = GetRestaurantsViewModel();
                return View("Index", reload);
            }
            int r = random.Next(names.Count);

            var selection = (string)names[r];

            return View("PickRandom", selection);
        }
    }
}
