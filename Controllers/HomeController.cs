using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LunchApp.Models;
using LunchApp.Models.ViewModels;
using LunchApp.Dal;

namespace LunchApp.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
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
                Restaurants = _context.Set<Restaurant>()
            };            

            return rvm;
        }

        public IActionResult PickRandom(RestaurantsViewModel restaurant)
        {

            Random random = new Random();
            var names = new List<string>();

            foreach (var item in restaurant.Restaurants)
            {
                if (item.IsSelected)
                {
                    names.Add(item.Name);
                }
            }
            
            int r = random.Next(names.Count);

            var selection = (string)names[r];

            return View("PickRandom", selection);
        }
    }
}
