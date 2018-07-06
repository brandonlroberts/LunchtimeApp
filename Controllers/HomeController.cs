using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LunchApp.Models;

namespace LunchApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var Restaurant = GetRestaurants(); 

            return View(Restaurant);
        }
        public static IEnumerable<Restaurant>  GetRestaurants()
        {
            return new List<Restaurant>
            { 
                new Restaurant {Name = "Tokyo"},
                new Restaurant {Name = "Buffalo Wild Wings"},
                new Restaurant {Name = "Five Guys"},
                new Restaurant {Name = "BJ's"},
                new Restaurant {Name = "Skyline"},
                new Restaurant {Name = "Chipotle"},
                new Restaurant {Name = "Wings and Rings"},
                new Restaurant {Name = "Larosa's"},
                new Restaurant {Name = "Friendly Stop"},
            };
        }

        public IActionResult PickRandom()
        {
            var restaurants = GetRestaurants();
            Random random = new Random();
            var names = new List<string>();

            foreach (var item in restaurants)
            {
                names.Add(item.Name);
            }
            
            int r = random.Next(names.Count);

            var selection = (string)names[r];

            return View("PickRandom", selection);
        }
    }
}
