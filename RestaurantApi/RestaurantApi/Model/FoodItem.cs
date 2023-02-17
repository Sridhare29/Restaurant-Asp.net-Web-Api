using System.ComponentModel.DataAnnotations;

namespace RestaurantApi.Model
{
    public class FoodItem
    {
        [Key]
        public int FoodItemId { get; set; }
        public string FoodItemName { get; set; }
        public decimal Price { get; set; }
    }
}
