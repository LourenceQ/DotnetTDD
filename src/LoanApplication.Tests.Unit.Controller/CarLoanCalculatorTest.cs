using LoanApplication.Core;
using LoanApplication.Core.DTO;
using LoanApplication.Core.Model;
using static LoanApplication.Core.DTO.LoanDTO;

namespace LoanApplication.Tests.Unit.Controller;

public class CarLoanCalculatorTest
{
    private CarLoanCalculator carLoanCalculator;
    public CarLoanCalculatorTest()
    {
        RateParser rateParser = new RateParser();
        this.carLoanCalculator = new CarLoanCalculator(rateParser);
    }

    [Fact]
    public void Test_CalculateLoan_ShouldReturnLoan()
    {
        // first scenario
        LoanDTO loanDTO1 = new LoanDTO();
        loanDTO1.LoanTypeDTO = LoanDTO.LoanType.CarLoan;
        loanDTO1.LocationTypeDTO = LocationType.Location1;
        loanDTO1.JobTypeDTO = JobType.Professional;
        Loan loan1 = carLoanCalculator.CalculateLoan(loanDTO1);

        Assert.NotNull(loan1);
        Assert.Equal(8, loan1.InterestRate);

        // second scenario
        LoanDTO loanDTO2 = new LoanDTO();
        loanDTO2.LoanTypeDTO = LoanDTO.LoanType.CarLoan;
        loanDTO2.LocationTypeDTO = LocationType.Location2;
        loanDTO2.JobTypeDTO = JobType.Professional;
        Loan loan2 = carLoanCalculator.CalculateLoan(loanDTO2);

        Assert.NotNull(loan2);
        Assert.Equal(10, loan2.InterestRate);
    }



    [Theory, InlineData(new LoanDTO
    {
        LoanType = LoanDTO.LoanType.CarLoan
    ,
        JobType = JobType.Professional,
        LocationTypeDTO = LocationType.Location1
    })]
    public void Test_CalculateLoan_ShouldReturnCorrectRate()
    {
        Loan loan = carLoanCalculator.CalculateLoan(loanDTO);
        Assert.NotNull(loan);
        Assert.Equal(8, loan.InterestRate);
    }
}
