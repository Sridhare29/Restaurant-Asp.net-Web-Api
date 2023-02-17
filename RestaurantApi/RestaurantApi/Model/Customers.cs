using System.ComponentModel.DataAnnotations;

namespace RestaurantApi.Model
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }    
        public string MobileNumber { get; set; }
    }
}
