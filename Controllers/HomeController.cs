using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LunchApp.Models.Base;

namespace LunchApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var restaurants = GetBaseRestaurants(); 

            return View(restaurants);
        }
        public static IEnumerable<BaseRestaurants>  GetBaseRestaurants()
        {
            return new List<BaseRestaurants>
            { 
                new BaseRestaurants {Name = "Tokyo"},
                new BaseRestaurants {Name = "Buffalo Wild Wings"},
                new BaseRestaurants {Name = "Five Guys"},
                new BaseRestaurants {Name = "BJ's"},
                new BaseRestaurants {Name = "Frisch's"},
            };
        }

        public IActionResult PickRandom()
        {
            var restaurants = GetBaseRestaurants();
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
