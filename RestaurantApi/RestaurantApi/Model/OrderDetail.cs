using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RestaurantApi.Model
{
    public class OrderDetail
    {
        [Key]
        public long OrderDetailId { get; set; }  
        public long OrderMasterId { get; set; }
        public int FoodItemId { get; set; } 
        public decimal FoodItemPrice { get; set; }
        public int Quantity { get; set; }
        [JsonIgnore]
        public FoodItem? Fooditems  { get; set; }
    }
}
