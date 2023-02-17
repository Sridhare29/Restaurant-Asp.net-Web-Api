using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RestaurantApi.Model
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }  
        public string OrderMasterId { get; set; }
        public OrderMaster orderMaster { get; set; }
        public int FoodItemId { get; set; }
        [JsonIgnore]
        public FoodItem FoodItem { get; set; }  
        public string FoodItemPrice { get; set; }
        public string Quantity { get; set; }    
    }
}
