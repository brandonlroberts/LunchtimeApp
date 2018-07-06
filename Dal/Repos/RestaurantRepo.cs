using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LunchApp.Dal.Interfaces;
using LunchApp.Models;

namespace LunchApp.Dal.Repos
{
    public class RestaurantRepo : IRestaurantRepo
    {
        private readonly ApplicationDbContext _context;

        public RestaurantRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Restaurant> GetListOfRestaurants()
        {
            var restaurants = _context.Set<Restaurant>().ToList();

            return restaurants;
        }
    }
}
