using LoanApplication.Core.Model;

namespace LoanApplication.Core;

public class Loan
{
    public bool IsElligible { get; set; }
    public string? Description { get; set; }
    public float DiscountFactor { get; set; }
    public DTO.LoanType LoanType { get; set; }
    public float InterestRate { get; set; }
    public int LoanId { get; set; }
    public long Amount { get; set; }
    public double Rate { get; set; }
    public short ServiceYear { get; set; }
    public bool HasDefaulted { get; set; }
    public Person Person { get; set; }
}
