using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RestaurantApi.Model
{
    public class OrderMaster
    {
        [Key]
        public int OrderMasterId { get; set; }
        [Column(TypeName="nvarchar(75)")]
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        [JsonIgnore]
        public Customers customers { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        public string Payment { get; set; }
        public decimal GTotal { get; set; }
    }
}
