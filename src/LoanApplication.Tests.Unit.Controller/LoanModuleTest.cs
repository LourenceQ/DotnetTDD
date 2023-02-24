using LoanApplication.Core;
using LoanApplication.Core.Model;

namespace LoanApplication.Tests.Unit.Controller;

public class LoanModuleTest : IDisposable
{
    public LoanModuleTest(LoanAppContext context)
    {
        Context = new LoanAppContext();
    }

    public LoanAppContext Context { get; private set; }
    public void Dispose()
    {
        Context = null;
    }

    [Fact]
    public void TestSAveLoan_ShouldReturnTrue()
    {
        Loan loan = new Loan { Description = "Car Loan" };
        Context.Loan.Add(loan);
        var isSaved = Context.Save();
        Assert.True(isSaved);
    }
}
