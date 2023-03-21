using LoanApplication.Core;
using LoanApplication.Core.Repository;
using Moq;

namespace LoanApplication.Tests.Unit;

public class LoanServiceTest
{
    private Mock<ILoanRepository> loanRepository;
    private LoanService loanService;
    public LoanServiceTest()
    {
        loanRepository = new Mock<ILoanRepository>();
        List<Loan> loans = new List<Loan>
        {
            new Loan { Amount = 120000, Rate = 12.5, ServiceYear = 5, HasDefaulted = false },
            new Loan { Amount = 150000, Rate = 12.5, ServiceYear = 4, HasDefaulted = true },
            new Loan { Amount = 200000, Rate = 12.5, ServiceYear = 5, HasDefaulted = false }

        };
        loanRepository.Setup(x => x.GetCarLoans()).Returns(loans);
        loanService = new LoanService(loanRepository.Object);
    }

    [Fact]
    public void Test_GetBadCarLoans_ShouldReturnLoans()
    {
        List<Loan> badLoans = loanService.GetBadCarLoans();
        Assert.NotNull(badLoans);
    }
}
