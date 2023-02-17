using System.ComponentModel.DataAnnotations;

namespace RestaurantApi.Model
{
    public class OrderMaster
    {
        [Key]
        public int OrderMasterId { get; set; }
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public string Payment { get; set; }
        public decimal GTotal { get; set; }
    }
}
