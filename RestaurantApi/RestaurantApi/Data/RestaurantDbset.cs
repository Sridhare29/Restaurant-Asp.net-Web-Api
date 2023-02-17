using Microsoft.EntityFrameworkCore;
using RestaurantApi.Model;

namespace RestaurantApi.Data
{
    public class RestaurantDbset :DbContext
    {
        public RestaurantDbset(DbContextOptions<RestaurantDbset> options):base(options)
        {
            
        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<OrderMaster> OrderMasters { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
