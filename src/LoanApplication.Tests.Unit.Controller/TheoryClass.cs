using LoanApplication.Core.DTO;

namespace LoanApplication.Tests.Unit.Controller;

public class TheoryClass
{
    [Theory, InlineData(new LoanDTO {LoanType = LoanDTO.LoanType.CarLoan
        , JobType = LoanDTO.JobType.Professional
        , LocationType = LoanDTO.LocationType.Location1})]
    public void Test_CalculateLoan_ShouldReturnBoolean(LoanDTO loanDTO)
    {
        Assert.Equal(4, word.Length);
    }
}
