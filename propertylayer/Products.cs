using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace propertylayer
{
    public class Products
    {
        [Key]
        public int ProductId {  get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice {  get; set; }
        public int quantity {  get; set; }
        public decimal TotalPrice {  get; set; }
        public string ProductCode {  get; set; }
        public int CategoryId {  get; set; }
        [NotMapped]
        public virtual category? category { get; set; }
    }
}
