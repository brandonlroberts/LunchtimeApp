using LunchApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LunchApp.Dal
{
    public class ApplicationDbContext : DbContext    
    {
        public DbSet<Restaurant> Restaurants{ get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options)
        {
            
        }
    }
}