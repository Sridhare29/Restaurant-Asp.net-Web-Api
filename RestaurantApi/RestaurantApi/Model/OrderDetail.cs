using System.ComponentModel.DataAnnotations;

namespace RestaurantApi.Model
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public string OrderMasterId { get; set; }
        public int FoodItemId { get; set; }
        public string FoodItemPrice { get; set; }
        public string Quantity { get; set; }    
    }
}
