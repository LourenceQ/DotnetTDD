using LoanApplication.Core;
using LoanApplication.Core.Model;

namespace LoanApplication.Tests.Unit.Controller;

public class LoanModuleTest : IClassFixture<EFCoreFixture>
{
    EFCoreFixture efCoreFixture;
    public LoanModuleTest(EFCoreFixture eFCoreFixture)
    {
        this.efCoreFixture = eFCoreFixture;
    }

    [Fact]
    public void TestSAveLoan_ShouldReturnTrue()
    {
        Loan loan = new Loan { Description = "Car Loan" };
        efCoreFixture.Context.Loan.Add(loan);
        var isSaved = efCoreFixture.Context.Save();
        Assert.True(isSaved);
    }
}
