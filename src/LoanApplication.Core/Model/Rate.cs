namespace LoanApplication.Core.Model;

public class Rate
{
    public string CurrencyCode { get; set; }
    public string BaseCurrency { get; set; }
    public decimal Amount { get; set; }
}
