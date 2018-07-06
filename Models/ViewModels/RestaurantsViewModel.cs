using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LunchApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LunchApp.Models.ViewModels
{
    
    public class RestaurantsViewModel
    {
       public List<Restaurant> Restaurants { get; set; } 
    }
}
