using System.ComponentModel.DataAnnotations;

namespace ProductProperties
{
    public class Product
    {
        [Key]
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProDescription {  get; set; }
        public decimal? Price { get; set; }
        public int? Quantity {  get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? Updated { get; set; }


    }
}
