using System;

namespace LunchApp.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string PhilApproved { get; set; }      
        public DateTime LastSelected { get; set; }
        public bool IsSelected { get; set; }
    }
}