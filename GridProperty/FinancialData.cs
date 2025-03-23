using System.ComponentModel.DataAnnotations;

namespace GridProperty
{
    public class FinancialData
    {
        [Key]
        public int Id { get; set; }
        public string? Ticker {  get; set; }
        public DateTime Timeline {  get; set; }
        public string? Instrument {  get; set; }
        public decimal ProfitLoss {  get; set; }
        public decimal TotalValue { get; set; }


    }
}
