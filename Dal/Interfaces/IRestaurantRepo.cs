using System.Collections.Generic;
using LunchApp.Models;

namespace LunchApp.Dal.Interfaces
{
    public interface IRestaurantRepo
    {
        List<Restaurant> GetListOfRestaurants();
    }
}