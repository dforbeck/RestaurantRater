using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.WebMVC.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }

        public class RestaurantDBContext : DbContext //snapshot of the dataset
        {
            public DbSet<Restaurant>Restaurants { get; set; } //defining the dbcontext referene type

        }
    }
}