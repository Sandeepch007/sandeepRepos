using System.ComponentModel.DataAnnotations;

namespace PropertiesPROCUST
{
    public class ProCust
    {
        [Key]
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProDescription { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public int? CustId { get; set; }
        public string? CustName { get; set; }
        public string? CustLocation { get; set; }
        public string? CustPhone {  get; set; }
        public string? CustEmailId { get; set; }
        public string? CustAadharCard {  get; set; }
        public string? CustPassport {  get; set; }
}
}
