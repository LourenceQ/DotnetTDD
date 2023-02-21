using LoanApplication.Core.Repository;

namespace DotnetTddApproach.NUnit;

[TestFixture]
public class LoanRepositoryTestNUnit
{
    public LoanRepository loanRepository;

    [OneTimeSetUp]
    public void SetupTest()
    {
        loanRepository = new LoanRepository();
    }

    [Test]
    public void Test_GetLoanById_ShouldReturnLoan()
    {
        var loan = loanRepository.GetLoanById(12);
        Assert.IsNotNull(loan);
    }
}