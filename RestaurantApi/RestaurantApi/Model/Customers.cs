using System.ComponentModel.DataAnnotations;

namespace RestaurantApi.Model
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        [Phone]
        public string? MobileNumber { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
    }
}
