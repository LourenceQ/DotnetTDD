using LoanApplication.Core.DTO;
using LoanApplication.Core.Model;

namespace LoanApplication.Core;

public class CarLoanCalculator : LoanCalculator
{
    public CarLoanCalculator(IRateParser rateParser) : base(rateParser)
    {
        base.rateParser = rateParser;
    }

    public override Loan CalculateLoan(LoanDTO loanDTO)
    {
        Loan loan = new();
        loan.LoanType = loanDTO.LoanType;
        loan.InterestRate = rateParser.GetRateByLoanType(loanDTO.LoanType);

        if (loanDTO.LocationTypeDTO == LoanDTO.LocationType.Location2)
            loan.InterestRate = 10F;

        return loan;
    }
}
