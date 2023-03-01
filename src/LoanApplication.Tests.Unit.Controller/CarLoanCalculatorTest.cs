using LoanApplication.Core;
using LoanApplication.Core.DTO;
using LoanApplication.Core.Model;
using static LoanApplication.Core.DTO.LoanDTO;

namespace LoanApplication.Tests.Unit.Controller;

public class CarLoanCalculatorTest
{
    private CarLoanCalculator carLoanCalculator;
    public CarLoanCalculator()
    {
        RateParser rateParser = new RateParser();
        this.carLoanCalculator = new CarLoanCalculator(rateParser);
    }

    [Fact]
    public void Test_CalculateLoan_ShouldReturnLoan()
    {
        // first scenario
        LoanDTO loanDTO1 = new LoanDTO();
        loanDTO1.LoanType = LoanType.CarLoan;
        loanDTO1.LocationType = LocationType.Location1;
        loanDTO1.JobType = JobType.Professional
        Loan loan1 = carLoanCalculator.CalculateLoan(loanDTO1);

        Assert.NotNull(loan1);
        Assert.Equal(8, loan1.InterestRate);

        // second scenario
        LoanDTO loanDTO2 = new LoanDTO();
        loanDTO2.LoanType = LoanType.CarLoan;
        loanDTO2.LocationType = LocationType.Location2;
        loanDTO2.JobType = JobType.Professional;
        Loan loan2 = carLoanCalculator.CalculateLoan(loanDTO2);

        Assert.NotNull(loan2);
        Assert.Equal(10, loan2.InterestRate);
    }
}
