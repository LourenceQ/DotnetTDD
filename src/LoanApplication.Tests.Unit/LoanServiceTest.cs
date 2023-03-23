using LoanApplication.Core;
using LoanApplication.Core.Model;
using LoanApplication.Core.Repository;
using Moq;

namespace LoanApplication.Tests.Unit;

public class LoanServiceTest
{
    private Mock<ILoanRepository> loanRepository;
    private LoanService loanService;
    public LoanServiceTest()
    {
        /*loanRepository = new Mock<ILoanRepository>();
        List<Loan> loans = new List<Loan>
        {
            new Loan { Amount = 120000, Rate = 12.5, ServiceYear = 5, HasDefaulted = false },
            new Loan { Amount = 150000, Rate = 12.5, ServiceYear = 4, HasDefaulted = true },
            new Loan { Amount = 200000, Rate = 12.5, ServiceYear = 5, HasDefaulted = false }

        };
        loanRepository.Setup(x => x.GetCarLoans()).Returns(loans);
        loanService = new LoanService(loanRepository.Object);*/

        List<Person> people = new List<Person>
        {
         new Person { FirstName = "Donald", LastName = "Duke", Age =30},
         new Person { FirstName = "Ayobami", LastName = "Adewole", Age =20}
        };
        Mock<ILoanRepository> loanRepository = new Mock<ILoanRepository>();
        loanRepository.Setup(x => x.GetCarLoanDefaulters(It.IsInRange<int>(1, 5, Moq.Range.Inclusive)))
            .Returns(people);
    }

    [Fact]
    public void Test_GetBadCarLoans_ShouldReturnLoans()
    {
        List<Loan> badLoans = loanService.GetBadCarLoans();
        Assert.NotNull(badLoans);
    }
}
